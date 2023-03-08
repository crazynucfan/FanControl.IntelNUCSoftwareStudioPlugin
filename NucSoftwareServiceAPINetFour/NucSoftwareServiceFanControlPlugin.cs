using FanControl.Plugins;
using NucSoftwareServiceAPINetFour.NssServicePerformanceTuningService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NucSoftwareServiceAPINetFour
{
    public class NucSoftwareServiceFanControlPlugin : IPlugin2
    {
        string IPlugin.Name => "NUC Software Service Plugin";

        void IPlugin.Close()
        {
            StaticFanController.Close();
        }

        void IPlugin.Initialize()
        {
            StaticFanController.EnsureWorkingWcfClient();            
        }

        void IPlugin.Load(IPluginSensorsContainer _container)
        {
            _container.ControlSensors.Add(new ControlSensor("CPUFanSpeed", "CPUFanSpeed"));
            _container.ControlSensors.Add(new ControlSensor("SystemFan1", "SystemFan1"));
            _container.ControlSensors.Add(new ControlSensor("SystemFan2", "SystemFan2"));            
        }

        void IPlugin2.Update()
        {
            //do nothing
        }
    }
}
