namespace TECControl
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.lstPorts = new System.Windows.Forms.ComboBox();
            this.cmdRefreshPorts = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnableSafety = new System.Windows.Forms.CheckBox();
            this.sliderColdTemp = new System.Windows.Forms.TrackBar();
            this.lblCoolantSlider = new System.Windows.Forms.Label();
            this.lblDewPointOffsetSlider = new System.Windows.Forms.Label();
            this.sliderDewPointOffset = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPWM = new System.Windows.Forms.TextBox();
            this.txtColdTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCaseTemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDewPoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTempTarget = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDewPointOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOffsetEnabled = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtActualTarget = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chartPWM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtFirmware = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartCold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderColdTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDewPointOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCold)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 500;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // lstPorts
            // 
            this.lstPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(12, 12);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(121, 21);
            this.lstPorts.TabIndex = 1;
            this.lstPorts.SelectedIndexChanged += new System.EventHandler(this.lstPorts_SelectedIndexChanged);
            // 
            // cmdRefreshPorts
            // 
            this.cmdRefreshPorts.Location = new System.Drawing.Point(139, 11);
            this.cmdRefreshPorts.Name = "cmdRefreshPorts";
            this.cmdRefreshPorts.Size = new System.Drawing.Size(86, 23);
            this.cmdRefreshPorts.TabIndex = 2;
            this.cmdRefreshPorts.Text = "Refresh Ports";
            this.cmdRefreshPorts.UseVisualStyleBackColor = true;
            this.cmdRefreshPorts.Click += new System.EventHandler(this.cmdRefreshPorts_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Enabled = false;
            this.cmdApply.Location = new System.Drawing.Point(175, 224);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(86, 23);
            this.cmdApply.TabIndex = 3;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Coolant Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimum Temperature Above Dew Point";
            // 
            // chkEnableSafety
            // 
            this.chkEnableSafety.AutoSize = true;
            this.chkEnableSafety.Checked = true;
            this.chkEnableSafety.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSafety.Location = new System.Drawing.Point(15, 197);
            this.chkEnableSafety.Name = "chkEnableSafety";
            this.chkEnableSafety.Size = new System.Drawing.Size(144, 17);
            this.chkEnableSafety.TabIndex = 8;
            this.chkEnableSafety.Text = "Enable Dew Point Safety";
            this.chkEnableSafety.UseVisualStyleBackColor = true;
            this.chkEnableSafety.CheckedChanged += new System.EventHandler(this.chkEnableSafety_CheckedChanged);
            // 
            // sliderColdTemp
            // 
            this.sliderColdTemp.Location = new System.Drawing.Point(12, 69);
            this.sliderColdTemp.Maximum = 25;
            this.sliderColdTemp.Minimum = -5;
            this.sliderColdTemp.Name = "sliderColdTemp";
            this.sliderColdTemp.Size = new System.Drawing.Size(324, 45);
            this.sliderColdTemp.TabIndex = 9;
            this.sliderColdTemp.Value = 5;
            this.sliderColdTemp.Scroll += new System.EventHandler(this.sliderColdTemp_Scroll);
            // 
            // lblCoolantSlider
            // 
            this.lblCoolantSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoolantSlider.Location = new System.Drawing.Point(342, 53);
            this.lblCoolantSlider.Name = "lblCoolantSlider";
            this.lblCoolantSlider.Size = new System.Drawing.Size(67, 61);
            this.lblCoolantSlider.TabIndex = 10;
            this.lblCoolantSlider.Text = "5 C";
            this.lblCoolantSlider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDewPointOffsetSlider
            // 
            this.lblDewPointOffsetSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPointOffsetSlider.Location = new System.Drawing.Point(342, 130);
            this.lblDewPointOffsetSlider.Name = "lblDewPointOffsetSlider";
            this.lblDewPointOffsetSlider.Size = new System.Drawing.Size(67, 61);
            this.lblDewPointOffsetSlider.TabIndex = 12;
            this.lblDewPointOffsetSlider.Text = "2 C";
            this.lblDewPointOffsetSlider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sliderDewPointOffset
            // 
            this.sliderDewPointOffset.Location = new System.Drawing.Point(12, 146);
            this.sliderDewPointOffset.Minimum = -10;
            this.sliderDewPointOffset.Name = "sliderDewPointOffset";
            this.sliderDewPointOffset.Size = new System.Drawing.Size(324, 45);
            this.sliderDewPointOffset.TabIndex = 11;
            this.sliderDewPointOffset.Value = 2;
            this.sliderDewPointOffset.Scroll += new System.EventHandler(this.sliderDewPointOffset_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TEC PWM:";
            // 
            // txtPWM
            // 
            this.txtPWM.Location = new System.Drawing.Point(117, 47);
            this.txtPWM.Name = "txtPWM";
            this.txtPWM.ReadOnly = true;
            this.txtPWM.Size = new System.Drawing.Size(59, 20);
            this.txtPWM.TabIndex = 14;
            this.txtPWM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtColdTemp
            // 
            this.txtColdTemp.Location = new System.Drawing.Point(117, 73);
            this.txtColdTemp.Name = "txtColdTemp";
            this.txtColdTemp.ReadOnly = true;
            this.txtColdTemp.Size = new System.Drawing.Size(59, 20);
            this.txtColdTemp.TabIndex = 16;
            this.txtColdTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cold Loop Coolant:";
            // 
            // txtCaseTemp
            // 
            this.txtCaseTemp.Location = new System.Drawing.Point(117, 99);
            this.txtCaseTemp.Name = "txtCaseTemp";
            this.txtCaseTemp.ReadOnly = true;
            this.txtCaseTemp.Size = new System.Drawing.Size(59, 20);
            this.txtCaseTemp.TabIndex = 20;
            this.txtCaseTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Case Air:";
            // 
            // txtDewPoint
            // 
            this.txtDewPoint.Location = new System.Drawing.Point(327, 47);
            this.txtDewPoint.Name = "txtDewPoint";
            this.txtDewPoint.ReadOnly = true;
            this.txtDewPoint.Size = new System.Drawing.Size(59, 20);
            this.txtDewPoint.TabIndex = 22;
            this.txtDewPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dew Point:";
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(117, 125);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.ReadOnly = true;
            this.txtHumidity.Size = new System.Drawing.Size(59, 20);
            this.txtHumidity.TabIndex = 24;
            this.txtHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Humidity:";
            // 
            // txtTempTarget
            // 
            this.txtTempTarget.Location = new System.Drawing.Point(327, 21);
            this.txtTempTarget.Name = "txtTempTarget";
            this.txtTempTarget.ReadOnly = true;
            this.txtTempTarget.Size = new System.Drawing.Size(59, 20);
            this.txtTempTarget.TabIndex = 26;
            this.txtTempTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cold Coolant Target:";
            // 
            // txtDewPointOffset
            // 
            this.txtDewPointOffset.Location = new System.Drawing.Point(327, 73);
            this.txtDewPointOffset.Name = "txtDewPointOffset";
            this.txtDewPointOffset.ReadOnly = true;
            this.txtDewPointOffset.Size = new System.Drawing.Size(59, 20);
            this.txtDewPointOffset.TabIndex = 28;
            this.txtDewPointOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Dew Point Offset:";
            // 
            // txtOffsetEnabled
            // 
            this.txtOffsetEnabled.Location = new System.Drawing.Point(327, 99);
            this.txtOffsetEnabled.Name = "txtOffsetEnabled";
            this.txtOffsetEnabled.ReadOnly = true;
            this.txtOffsetEnabled.Size = new System.Drawing.Size(59, 20);
            this.txtOffsetEnabled.TabIndex = 30;
            this.txtOffsetEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Dew Point Safety Enabled:";
            // 
            // txtActualTarget
            // 
            this.txtActualTarget.Location = new System.Drawing.Point(327, 125);
            this.txtActualTarget.Name = "txtActualTarget";
            this.txtActualTarget.ReadOnly = true;
            this.txtActualTarget.Size = new System.Drawing.Size(59, 20);
            this.txtActualTarget.TabIndex = 32;
            this.txtActualTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Effective Coolant Target:";
            // 
            // chartPWM
            // 
            this.chartPWM.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartPWM.ChartAreas.Add(chartArea1);
            this.chartPWM.Location = new System.Drawing.Point(404, 3);
            this.chartPWM.Name = "chartPWM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Green;
            series1.Name = "Series1";
            this.chartPWM.Series.Add(series1);
            this.chartPWM.Size = new System.Drawing.Size(608, 230);
            this.chartPWM.TabIndex = 34;
            this.chartPWM.Text = "TEC PWM";
            title1.Name = "TEC PWM";
            title1.Text = "TEC PWM";
            this.chartPWM.Titles.Add(title1);
            // 
            // txtFirmware
            // 
            this.txtFirmware.Location = new System.Drawing.Point(117, 21);
            this.txtFirmware.Name = "txtFirmware";
            this.txtFirmware.ReadOnly = true;
            this.txtFirmware.Size = new System.Drawing.Size(59, 20);
            this.txtFirmware.TabIndex = 36;
            this.txtFirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Firmware:";
            // 
            // chartCold
            // 
            this.chartCold.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.Maximum = 25D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chartCold.ChartAreas.Add(chartArea2);
            this.chartCold.Location = new System.Drawing.Point(404, 239);
            this.chartCold.Name = "chartCold";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.Name = "Series1";
            this.chartCold.Series.Add(series2);
            this.chartCold.Size = new System.Drawing.Size(608, 230);
            this.chartCold.TabIndex = 37;
            this.chartCold.Text = "Coolant Temp";
            title2.Name = "Coolant Temp";
            title2.Text = "Coolant Temp";
            this.chartCold.Titles.Add(title2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirmware);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPWM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtColdTemp);
            this.groupBox1.Controls.Add(this.txtActualTarget);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtOffsetEnabled);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCaseTemp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDewPointOffset);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDewPoint);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHumidity);
            this.groupBox1.Controls.Add(this.txtTempTarget);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 157);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Status";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(175, 442);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(86, 23);
            this.cmdClose.TabIndex = 39;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 477);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartCold);
            this.Controls.Add(this.chartPWM);
            this.Controls.Add(this.lblDewPointOffsetSlider);
            this.Controls.Add(this.sliderDewPointOffset);
            this.Controls.Add(this.lblCoolantSlider);
            this.Controls.Add(this.sliderColdTemp);
            this.Controls.Add(this.chkEnableSafety);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.cmdRefreshPorts);
            this.Controls.Add(this.lstPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "TEC Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderColdTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDewPointOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ComboBox lstPorts;
        private System.Windows.Forms.Button cmdRefreshPorts;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnableSafety;
        private System.Windows.Forms.TrackBar sliderColdTemp;
        private System.Windows.Forms.Label lblCoolantSlider;
        private System.Windows.Forms.Label lblDewPointOffsetSlider;
        private System.Windows.Forms.TrackBar sliderDewPointOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPWM;
        private System.Windows.Forms.TextBox txtColdTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCaseTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDewPoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTempTarget;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDewPointOffset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOffsetEnabled;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActualTarget;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPWM;
        private System.Windows.Forms.TextBox txtFirmware;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdClose;
    }
}

