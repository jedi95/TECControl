using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECControl
{
    class Status
    {
        public string _revision;
        public float _PWM;
        public float _tCold;
        public float _tCase;
        public float _tDewPoint;
        public float _humidity;
        public sbyte _targetTemperature;
        public sbyte _dewPointOffset;
        public bool _enableDewPointSafety;
        public float _actualTarget;

        public Status(string[] data)
        {
            update(data);
        }

        public Config getConfig()
        {
            return new Config(_targetTemperature, _dewPointOffset, _enableDewPointSafety);
        }

        public void update(string[] data)
        {
            _revision = data[0];
            _PWM = float.Parse(data[1]);
            _tCold = float.Parse(data[2]);
            _tCase = float.Parse(data[3]);
            _tDewPoint = float.Parse(data[4]);
            _humidity = float.Parse(data[5]);
            _targetTemperature = sbyte.Parse(data[6]);
            _dewPointOffset = sbyte.Parse(data[7]);
            _enableDewPointSafety = bool.Parse(data[8]);
            _actualTarget = float.Parse(data[9]);
        }
    }
}
