using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NucSoftwareServiceAPINetFour.NssServicePerformanceTuningService;
using NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor;

namespace SimpleRunnerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            
            
            PerformanceTuningServiceContractClient _wcfServiceClient = new PerformanceTuningServiceContractClient(new WSHttpBinding(SecurityMode.Message), new EndpointAddress("http://localhost:43568/NssService/service/PerformanceTuning"));
            //SystemMonitorServiceContractClient _wcfMonitorServiceClient = new SystemMonitorServiceContractClient();

            string[] supportedFanTypes = _wcfServiceClient.SupportedFanTypes();


            foreach (var res in supportedFanTypes)
            {
                Console.WriteLine("Fan type: "+res);

                //FanControlAllFanSettings fanSettings = new FanControlAllFanSetting();
                //fanSettings.fanSettings[0].

                //_wcfServiceClient.
                
            }

            //Console.WriteLine(_wcfServiceClient.GetCurrentBiosFanModeName());

            //FanProfile fp = _wcfServiceClient.GetFanProfileData("SystemFan1");
            FanControlAllFanSettings fcas = new FanControlAllFanSettings();
            FanSetting fs1 = new FanSetting();
            
            fs1.Configuration1 = 1; 
            fs1.Configuration2 = 0;
            fs1.PrimaryMaximumTemperature = 100;
            fs1.PrimaryMinimumDuty = 58;
            fs1.PrimaryMinimumTemperature = 100;
            fs1.PrimaryFanOffTemperature = 0;
            fs1.primaryInputSourceConfiguration = PrimaryInputSourceConfiguration.CPUTemperature;
            fs1.PrimaryDutyIncrement = 3;
            

            FanSetting fs2 = new FanSetting();

            fs2.Configuration1 = 1;
            fs2.Configuration2 = 0;
            fs2.PrimaryMaximumTemperature = 100;
            fs2.PrimaryMinimumDuty = 58;
            fs2.PrimaryMinimumTemperature = 100;
            fs2.PrimaryFanOffTemperature = 0;
            fs2.primaryInputSourceConfiguration = PrimaryInputSourceConfiguration.CPUTemperature;
            fs2.PrimaryDutyIncrement = 3;

            FanSetting fs3 = new FanSetting();

            fs3.Configuration1 = 1;
            fs3.Configuration2 = 0;
            fs3.PrimaryMaximumTemperature = 100;
            fs3.PrimaryMinimumDuty = 58;
            fs3.PrimaryMinimumTemperature = 100;
            fs3.PrimaryFanOffTemperature = 0;
            fs3.primaryInputSourceConfiguration = PrimaryInputSourceConfiguration.CPUTemperature;
            fs3.PrimaryDutyIncrement = 3;

            fcas.fanSettings = new FanSetting[] { fs1, fs2, fs3 };

            //fcas.fanSettings
            _wcfServiceClient.SetFanCustom(fcas);

            //_wcfServiceClient.
            

            /*FanProfile[] fanProfiles = new FanProfile[]
            {
                
            };

            _wcfServiceClient.SetFanModeRN("Custom","SystemFan1",)*/

            //_wcfServiceClient.SetFanModeRN("Custom", "SystemFan1", new FanProfileRN[] {
            //    new FanProfileRN().
            //}); 

            //_wcfServiceClient.SetFanDutyCycleFixedMode("Custom", new byte[] { Convert.ToByte(30), Convert.ToByte(30), Convert.ToByte(30) });
        }
    }
}
