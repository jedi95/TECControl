using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECControl
{
    class Config
    {
        public sbyte _targetTemperature;
        public sbyte _dewPointOffset;
        public bool _enableDewPointSafety;
        
        public Config()
        {
            _targetTemperature = 5;
            _dewPointOffset = 2;
            _enableDewPointSafety = true;
        }
        public Config(sbyte targetTemperature, sbyte dewPointOffset, bool enableDewPointSafety)
        {
            _targetTemperature = targetTemperature;
            _dewPointOffset = dewPointOffset;
            _enableDewPointSafety = enableDewPointSafety;
        }

        public bool sendConfig(SerialPort port)
        {
            if (port != null && port.IsOpen)
            {
                byte[] command = new byte[4];
                command[0] = 247;
                command[1] = (byte)(_targetTemperature + 128);
                command[2] = (byte)(_dewPointOffset + 128);
                if (_enableDewPointSafety)
                {
                    command[3] = 1;
                }
                else
                {
                    command[3] = 0;
                }
                port.Write(command, 0, 4);
                return true;
            }
            return false;
        }
    }
}
