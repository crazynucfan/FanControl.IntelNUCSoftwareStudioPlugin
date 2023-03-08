using NucSoftwareServiceAPINetFour.NssServicePerformanceTuningService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NucSoftwareServiceAPINetFour
{
    internal class StaticFanController
    {
        public static byte CPUFanSpeed = 25;
        public static byte SystemFan1Speed = 25;
        public static byte SystemFan2Speed = 25;
        public static PerformanceTuningServiceContractClient WcfServiceClient = null;

        public static void EnsureWorkingWcfClient()
        {
            bool needNewClient = false;
            if (WcfServiceClient == null || WcfServiceClient.State != CommunicationState.Opened)
            {
                needNewClient = true;
            }
            //try a command, if its broken create a new context
            string[] res = null;
            try
            {
                res = WcfServiceClient.GetSupportedFanModes();
            }
            catch
            {
                needNewClient = true;
            }

            if(res != null)
            {
                needNewClient = false;
            }

            if ( needNewClient )
            {
                WcfServiceClient = new PerformanceTuningServiceContractClient(new WSHttpBinding(), new EndpointAddress("http://localhost:43568/NssService/service/PerformanceTuning?wsdl"));
            }
        }

        public static void Close()
        {
            EnsureWorkingWcfClient();
            WcfServiceClient.ApplyBiosPowerProfile("Custom");
            WcfServiceClient.Close();
            WcfServiceClient = null;
        }

        public static void SetValues()
        {
            EnsureWorkingWcfClient();
            FanControlAllFanSettings fcas = new FanControlAllFanSettings();
            FanSetting fs1 = new FanSetting();

            fs1.Configuration1 = 1;
            fs1.Configuration2 = 0;
            fs1.PrimaryMaximumTemperature = 100;
            fs1.PrimaryMinimumDuty = CPUFanSpeed;
            fs1.PrimaryMinimumTemperature = 100;
            fs1.PrimaryFanOffTemperature = 0;
            fs1.primaryInputSourceConfiguration = PrimaryInputSourceConfiguration.CPUTemperature;
            fs1.PrimaryDutyIncrement = 3;


            FanSetting fs2 = new FanSetting();

            fs2.Configuration1 = 1;
            fs2.Configuration2 = 0;
            fs2.PrimaryMaximumTemperature = 100;
            fs2.PrimaryMinimumDuty = SystemFan1Speed;
            fs2.PrimaryMinimumTemperature = 100;
            fs2.PrimaryFanOffTemperature = 0;
            fs2.primaryInputSourceConfiguration = PrimaryInputSourceConfiguration.CPUTemperature;
            fs2.PrimaryDutyIncrement = 3;

            FanSetting fs3 = new FanSetting();

            fs3.Configuration1 = 1;
            fs3.Configuration2 = 0;
            fs3.PrimaryMaximumTemperature = 100;
            fs3.PrimaryMinimumDuty = SystemFan2Speed;
            fs3.PrimaryMinimumTemperature = 100;
            fs3.PrimaryFanOffTemperature = 0;
            fs3.primaryInputSourceConfiguration = PrimaryInputSourceConfiguration.CPUTemperature;
            fs3.PrimaryDutyIncrement = 3;

            fcas.fanSettings = new FanSetting[] { fs1, fs2, fs3 };

            //fcas.fanSettings
            try
            {
                WcfServiceClient.SetFanCustom(fcas);
            }
            catch
            {

            }
        }
    }
}
