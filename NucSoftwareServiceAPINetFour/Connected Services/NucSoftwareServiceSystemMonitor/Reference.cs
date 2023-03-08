﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FanSpeed", Namespace="http://schemas.datacontract.org/2004/07/PerformanceTuningLibrary")]
    [System.SerializableAttribute()]
    public partial struct FanSpeed : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint speedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.FanType typeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint speed {
            get {
                return this.speedField;
            }
            set {
                if ((this.speedField.Equals(value) != true)) {
                    this.speedField = value;
                    this.RaisePropertyChanged("speed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.FanType type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FanType", Namespace="http://schemas.datacontract.org/2004/07/PerformanceTuningLibrary")]
    public enum FanType : byte {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotConnected = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CPUFan = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        dGPUFan = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SystemFan1 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SystemFan2 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LiquidCoolerFanPump = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unsupported = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CPUFan2 = 7,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SystemMonitorData", Namespace="http://schemas.datacontract.org/2004/07/SystemMonitorLibrary.Hardware")]
    [System.SerializableAttribute()]
    public partial class SystemMonitorData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> BatteryInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> DiscreteGpuInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> IntegratedGpuInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> MemoryInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> ProcessorInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string>[] StorageInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> SystemInformationField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> BatteryInformation {
            get {
                return this.BatteryInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.BatteryInformationField, value) != true)) {
                    this.BatteryInformationField = value;
                    this.RaisePropertyChanged("BatteryInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> DiscreteGpuInformation {
            get {
                return this.DiscreteGpuInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.DiscreteGpuInformationField, value) != true)) {
                    this.DiscreteGpuInformationField = value;
                    this.RaisePropertyChanged("DiscreteGpuInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> IntegratedGpuInformation {
            get {
                return this.IntegratedGpuInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.IntegratedGpuInformationField, value) != true)) {
                    this.IntegratedGpuInformationField = value;
                    this.RaisePropertyChanged("IntegratedGpuInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> MemoryInformation {
            get {
                return this.MemoryInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.MemoryInformationField, value) != true)) {
                    this.MemoryInformationField = value;
                    this.RaisePropertyChanged("MemoryInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> ProcessorInformation {
            get {
                return this.ProcessorInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcessorInformationField, value) != true)) {
                    this.ProcessorInformationField = value;
                    this.RaisePropertyChanged("ProcessorInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string>[] StorageInformation {
            get {
                return this.StorageInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.StorageInformationField, value) != true)) {
                    this.StorageInformationField = value;
                    this.RaisePropertyChanged("StorageInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> SystemInformation {
            get {
                return this.SystemInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemInformationField, value) != true)) {
                    this.SystemInformationField = value;
                    this.RaisePropertyChanged("SystemInformation");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NucSoftwareServiceSystemMonitor.ISystemMonitorServiceContract", CallbackContract=typeof(NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.ISystemMonitorServiceContractCallback))]
    public interface ISystemMonitorServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISystemMonitorServiceContract/Subscribe")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISystemMonitorServiceContract/Subscribe")]
        System.Threading.Tasks.Task SubscribeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISystemMonitorServiceContractCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISystemMonitorServiceContract/SystemMonitorDataCallback")]
        void SystemMonitorDataCallback(NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.FanSpeed[] FanData, NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.SystemMonitorData SystemData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISystemMonitorServiceContractChannel : NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.ISystemMonitorServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SystemMonitorServiceContractClient : System.ServiceModel.DuplexClientBase<NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.ISystemMonitorServiceContract>, NucSoftwareServiceAPINetFour.NucSoftwareServiceSystemMonitor.ISystemMonitorServiceContract {
        
        public SystemMonitorServiceContractClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public SystemMonitorServiceContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public SystemMonitorServiceContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SystemMonitorServiceContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SystemMonitorServiceContractClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
    }
}