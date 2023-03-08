using FanControl.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NucSoftwareServiceAPINetFour
{
    internal class ControlSensor : IPluginControlSensor
    {
        private string _id = "";
        string IPluginSensor.Id => _id;

        private string _name = "";
        string IPluginSensor.Name => _name;

        private float _value = 25;
        float? IPluginSensor.Value => _value;

        public ControlSensor(string id, string name)
        {
            _id = id;
            _name = name;
        }

        void IPluginControlSensor.Reset()
        {
            _value = 25;
        }

        void IPluginControlSensor.Set(float val)
        {
            _value = val;
            byte byteVal = ((byte)((int)_value));
            if (_id == "CPUFanSpeed")
            {
                StaticFanController.CPUFanSpeed = byteVal;
            }
            else if(_id == "SystemFan1")
            {
                StaticFanController.SystemFan1Speed = byteVal;
            }
            else if (_id == "SystemFan2")
            {
                StaticFanController.SystemFan2Speed = byteVal;
            }
            StaticFanController.SetValues();
        }

        void IPluginSensor.Update()
        {
            
        }
    }
}
