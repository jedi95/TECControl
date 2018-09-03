using System;
using System.Windows.Forms;
using System.IO.Ports;
using rtChart;

namespace TECControl
{
    public partial class frmMain : Form
    {
        SerialPort _port;
        Status status;
        Config config;
        kayChart pwmChart;
        kayChart coldChart;
        bool firstUpdate = false;
        public delegate int AddString(string message);

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshPorts();
            if (lstPorts.Items.Count == 1)
            {
                lstPorts.SelectedIndex = 0;
            }
            pwmChart = new kayChart(chartPWM, 60);
            coldChart = new kayChart(chartCold, 60);

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        private void refreshPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            lstPorts.Items.Clear();
            for (int i = 0; i<ports.Length; i++)
            {
                if (!lstPorts.Items.Contains(ports[i]))
                {
                    lstPorts.Items.Add(ports[i]);
                }
            }
        }
        private void lstPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_port != null)
            {
                _port.Close();
                _port = null;
            }
            try
            {
                _port = new SerialPort(lstPorts.Text);
                _port.Open();
                firstUpdate = true;
                RefreshTimer.Enabled = true;
                RefreshTimer.Start();
            }
            catch
            {
                _port = null;
                MessageBox.Show("Unable to open serial port: " + lstPorts.Text);
            }
        }

        private void cmdRefreshPorts_Click(object sender, EventArgs e)
        {
            refreshPorts();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            readStatus();
            updateInterface();
        }

        private void updateInterface()
        {
            bool applyEnable = false;
            if (status != null)
            {
                txtFirmware.Text = status._revision;
                txtPWM.Text = status._PWM.ToString() + "%";
                txtColdTemp.Text = status._tCold.ToString() + "°C";
                txtCaseTemp.Text = status._tCase.ToString() + "°C";
                txtDewPoint.Text = status._tDewPoint.ToString() + "°C";
                txtHumidity.Text = status._humidity.ToString() + "%";
                txtTempTarget.Text = status._targetTemperature.ToString() + "°C";
                txtDewPointOffset.Text = status._dewPointOffset.ToString() + "°C";
                txtOffsetEnabled.Text = status._enableDewPointSafety.ToString();
                txtActualTarget.Text = status._actualTarget.ToString() + "°C";
                pwmChart.TriggeredUpdate(status._PWM);
                coldChart.TriggeredUpdate(status._tCold);

                if (firstUpdate)
                {
                    sliderColdTemp.Value = status._targetTemperature;
                    sliderDewPointOffset.Value = status._dewPointOffset;
                    chkEnableSafety.Checked = status._enableDewPointSafety;
                    lblCoolantSlider.Text = sliderColdTemp.Value.ToString() + " C";
                    lblDewPointOffsetSlider.Text = sliderDewPointOffset.Value.ToString() + " C";
                    firstUpdate = false;
                }

                if (_port != null && _port.IsOpen)
                {
                    if ((sbyte)sliderColdTemp.Value != status._targetTemperature)
                    {
                        applyEnable = true;
                    }
                    if ((sbyte)sliderDewPointOffset.Value != status._dewPointOffset)
                    {
                        applyEnable = true;
                    }
                    if (chkEnableSafety.Checked != status._enableDewPointSafety)
                    {
                        applyEnable = true;
                    }
                }
            }
            cmdApply.Enabled = applyEnable;
        }

        private void readStatus()
        {
            if (_port != null && _port.IsOpen)
            {
                string data = "";
                try
                {
                    data = _port.ReadExisting();
                }
                catch
                {
                    _port.Close();
                    _port = null;
                }
                if (data.Length > 0)
                {
                    data = data.Trim('\n', ' ');
                    int index = data.LastIndexOf("\n") + 1;
                    if (index > -1)
                    {
                        data = data.Substring(index, data.Length - index);
                    }
                    string[] parts = data.Split(',');
                    if (parts.Length == 10)
                    {
                        status = new Status(parts);
                    }
                }
            }
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            config = new Config((sbyte)sliderColdTemp.Value, (sbyte)sliderDewPointOffset.Value, chkEnableSafety.Checked);
            config.sendConfig(_port);
            cmdApply.Enabled = false;
        }

        private void sliderColdTemp_Scroll(object sender, EventArgs e)
        {
            lblCoolantSlider.Text = sliderColdTemp.Value.ToString() + " C";
            cmdApply.Enabled = true;
        }

        private void sliderDewPointOffset_Scroll(object sender, EventArgs e)
        {
            lblDewPointOffsetSlider.Text = sliderDewPointOffset.Value.ToString() + " C";
            cmdApply.Enabled = true;
        }

        private void chkEnableSafety_CheckedChanged(object sender, EventArgs e)
        {
            cmdApply.Enabled = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if (_port != null && _port.IsOpen)
            {
                _port.Close();
            }
            this.Close();
        }

        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }
    }
}
