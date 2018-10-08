﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.CallingNameV3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CallingNameType", Namespace="http://schemas.datacontract.org/2004/07/CallingNameServiceV3")]
    [System.SerializableAttribute()]
    public partial class CallingNameType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BgIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CallingNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PresentationField;
        
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
        public int BgId {
            get {
                return this.BgIdField;
            }
            set {
                if ((this.BgIdField.Equals(value) != true)) {
                    this.BgIdField = value;
                    this.RaisePropertyChanged("BgId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CName {
            get {
                return this.CNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CNameField, value) != true)) {
                    this.CNameField = value;
                    this.RaisePropertyChanged("CName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CallingNumber {
            get {
                return this.CallingNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CallingNumberField, value) != true)) {
                    this.CallingNumberField = value;
                    this.RaisePropertyChanged("CallingNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Presentation {
            get {
                return this.PresentationField;
            }
            set {
                if ((object.ReferenceEquals(this.PresentationField, value) != true)) {
                    this.PresentationField = value;
                    this.RaisePropertyChanged("Presentation");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScreenPopType", Namespace="http://schemas.datacontract.org/2004/07/CallingNameServiceV3")]
    [System.SerializableAttribute()]
    public partial class ScreenPopType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NpaNxxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Common.CallingNameV3.ScreenPopServerType[] ServersFieldField;
        
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
        public string DescriptionField {
            get {
                return this.DescriptionFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionFieldField, value) != true)) {
                    this.DescriptionFieldField = value;
                    this.RaisePropertyChanged("DescriptionField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NpaNxx {
            get {
                return this.NpaNxxField;
            }
            set {
                if ((object.ReferenceEquals(this.NpaNxxField, value) != true)) {
                    this.NpaNxxField = value;
                    this.RaisePropertyChanged("NpaNxx");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Common.CallingNameV3.ScreenPopServerType[] ServersField {
            get {
                return this.ServersFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.ServersFieldField, value) != true)) {
                    this.ServersFieldField = value;
                    this.RaisePropertyChanged("ServersField");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScreenPopServerType", Namespace="http://schemas.datacontract.org/2004/07/CallingNameServiceV3")]
    [System.SerializableAttribute()]
    public partial class ScreenPopServerType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PortNumberFieldField;
        
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
        public string DescriptionField {
            get {
                return this.DescriptionFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionFieldField, value) != true)) {
                    this.DescriptionFieldField = value;
                    this.RaisePropertyChanged("DescriptionField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddressField {
            get {
                return this.IpAddressFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressFieldField, value) != true)) {
                    this.IpAddressFieldField = value;
                    this.RaisePropertyChanged("IpAddressField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PortNumberField {
            get {
                return this.PortNumberFieldField;
            }
            set {
                if ((this.PortNumberFieldField.Equals(value) != true)) {
                    this.PortNumberFieldField = value;
                    this.RaisePropertyChanged("PortNumberField");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScreenPopSubscriberType", Namespace="http://schemas.datacontract.org/2004/07/CallingNameServiceV3")]
    [System.SerializableAttribute()]
    public partial class ScreenPopSubscriberType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ScreenPopEnabledFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubscriberPhoneNumberFieldField;
        
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
        public bool ScreenPopEnabledField {
            get {
                return this.ScreenPopEnabledFieldField;
            }
            set {
                if ((this.ScreenPopEnabledFieldField.Equals(value) != true)) {
                    this.ScreenPopEnabledFieldField = value;
                    this.RaisePropertyChanged("ScreenPopEnabledField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubscriberPhoneNumberField {
            get {
                return this.SubscriberPhoneNumberFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.SubscriberPhoneNumberFieldField, value) != true)) {
                    this.SubscriberPhoneNumberFieldField = value;
                    this.RaisePropertyChanged("SubscriberPhoneNumberField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CallingNameV3.ICallingNameService")]
    public interface ICallingNameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetCallingEntry", ReplyAction="http://tempuri.org/ICallingNameService/GetCallingEntryResponse")]
        Common.CallingNameV3.CallingNameType GetCallingEntry(string loginToken, string dn, int bgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetCallingEntry", ReplyAction="http://tempuri.org/ICallingNameService/GetCallingEntryResponse")]
        System.Threading.Tasks.Task<Common.CallingNameV3.CallingNameType> GetCallingEntryAsync(string loginToken, string dn, int bgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetCallingEntries", ReplyAction="http://tempuri.org/ICallingNameService/GetCallingEntriesResponse")]
        Common.CallingNameV3.CallingNameType[] GetCallingEntries(string loginToken, string dn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetCallingEntries", ReplyAction="http://tempuri.org/ICallingNameService/GetCallingEntriesResponse")]
        System.Threading.Tasks.Task<Common.CallingNameV3.CallingNameType[]> GetCallingEntriesAsync(string loginToken, string dn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertCallingEntry", ReplyAction="http://tempuri.org/ICallingNameService/InsertCallingEntryResponse")]
        void InsertCallingEntry(string loginToken, string dn, int bgId, string presentation, string cName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertCallingEntry", ReplyAction="http://tempuri.org/ICallingNameService/InsertCallingEntryResponse")]
        System.Threading.Tasks.Task InsertCallingEntryAsync(string loginToken, string dn, int bgId, string presentation, string cName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertCallingEntries", ReplyAction="http://tempuri.org/ICallingNameService/InsertCallingEntriesResponse")]
        void InsertCallingEntries(string loginToken, Common.CallingNameV3.CallingNameType[] entries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertCallingEntries", ReplyAction="http://tempuri.org/ICallingNameService/InsertCallingEntriesResponse")]
        System.Threading.Tasks.Task InsertCallingEntriesAsync(string loginToken, Common.CallingNameV3.CallingNameType[] entries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteCallingEntry", ReplyAction="http://tempuri.org/ICallingNameService/DeleteCallingEntryResponse")]
        void DeleteCallingEntry(string loginToken, string dn, int bgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteCallingEntry", ReplyAction="http://tempuri.org/ICallingNameService/DeleteCallingEntryResponse")]
        System.Threading.Tasks.Task DeleteCallingEntryAsync(string loginToken, string dn, int bgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteCallingEntries", ReplyAction="http://tempuri.org/ICallingNameService/DeleteCallingEntriesResponse")]
        void DeleteCallingEntries(string loginToken, Common.CallingNameV3.CallingNameType[] entries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteCallingEntries", ReplyAction="http://tempuri.org/ICallingNameService/DeleteCallingEntriesResponse")]
        System.Threading.Tasks.Task DeleteCallingEntriesAsync(string loginToken, Common.CallingNameV3.CallingNameType[] entries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetAllScreenPopEntries", ReplyAction="http://tempuri.org/ICallingNameService/GetAllScreenPopEntriesResponse")]
        Common.CallingNameV3.ScreenPopType[] GetAllScreenPopEntries(string loginToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetAllScreenPopEntries", ReplyAction="http://tempuri.org/ICallingNameService/GetAllScreenPopEntriesResponse")]
        System.Threading.Tasks.Task<Common.CallingNameV3.ScreenPopType[]> GetAllScreenPopEntriesAsync(string loginToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertScreenPopEntry", ReplyAction="http://tempuri.org/ICallingNameService/InsertScreenPopEntryResponse")]
        void InsertScreenPopEntry(string loginToken, string npaNxx, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertScreenPopEntry", ReplyAction="http://tempuri.org/ICallingNameService/InsertScreenPopEntryResponse")]
        System.Threading.Tasks.Task InsertScreenPopEntryAsync(string loginToken, string npaNxx, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteScreenPopEntry", ReplyAction="http://tempuri.org/ICallingNameService/DeleteScreenPopEntryResponse")]
        void DeleteScreenPopEntry(string loginToken, string npaNxx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteScreenPopEntry", ReplyAction="http://tempuri.org/ICallingNameService/DeleteScreenPopEntryResponse")]
        System.Threading.Tasks.Task DeleteScreenPopEntryAsync(string loginToken, string npaNxx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertScreenPopSubscriber", ReplyAction="http://tempuri.org/ICallingNameService/InsertScreenPopSubscriberResponse")]
        void InsertScreenPopSubscriber(string loginToken, string calledNumber, bool videoScreenPopEnabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/InsertScreenPopSubscriber", ReplyAction="http://tempuri.org/ICallingNameService/InsertScreenPopSubscriberResponse")]
        System.Threading.Tasks.Task InsertScreenPopSubscriberAsync(string loginToken, string calledNumber, bool videoScreenPopEnabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetAllNetEchoSubscribers", ReplyAction="http://tempuri.org/ICallingNameService/GetAllNetEchoSubscribersResponse")]
        Common.CallingNameV3.ScreenPopSubscriberType[] GetAllNetEchoSubscribers(string loginToken, string npaNxx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetAllNetEchoSubscribers", ReplyAction="http://tempuri.org/ICallingNameService/GetAllNetEchoSubscribersResponse")]
        System.Threading.Tasks.Task<Common.CallingNameV3.ScreenPopSubscriberType[]> GetAllNetEchoSubscribersAsync(string loginToken, string npaNxx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetNetEchoSubscriber", ReplyAction="http://tempuri.org/ICallingNameService/GetNetEchoSubscriberResponse")]
        Common.CallingNameV3.ScreenPopSubscriberType GetNetEchoSubscriber(string loginToken, string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/GetNetEchoSubscriber", ReplyAction="http://tempuri.org/ICallingNameService/GetNetEchoSubscriberResponse")]
        System.Threading.Tasks.Task<Common.CallingNameV3.ScreenPopSubscriberType> GetNetEchoSubscriberAsync(string loginToken, string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteScreenPopSubscriber", ReplyAction="http://tempuri.org/ICallingNameService/DeleteScreenPopSubscriberResponse")]
        void DeleteScreenPopSubscriber(string loginToken, string calledNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICallingNameService/DeleteScreenPopSubscriber", ReplyAction="http://tempuri.org/ICallingNameService/DeleteScreenPopSubscriberResponse")]
        System.Threading.Tasks.Task DeleteScreenPopSubscriberAsync(string loginToken, string calledNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICallingNameServiceChannel : Common.CallingNameV3.ICallingNameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CallingNameServiceClient : System.ServiceModel.ClientBase<Common.CallingNameV3.ICallingNameService>, Common.CallingNameV3.ICallingNameService {
        
        public CallingNameServiceClient() {
        }
        
        public CallingNameServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CallingNameServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CallingNameServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CallingNameServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Common.CallingNameV3.CallingNameType GetCallingEntry(string loginToken, string dn, int bgId) {
            return base.Channel.GetCallingEntry(loginToken, dn, bgId);
        }
        
        public System.Threading.Tasks.Task<Common.CallingNameV3.CallingNameType> GetCallingEntryAsync(string loginToken, string dn, int bgId) {
            return base.Channel.GetCallingEntryAsync(loginToken, dn, bgId);
        }
        
        public Common.CallingNameV3.CallingNameType[] GetCallingEntries(string loginToken, string dn) {
            return base.Channel.GetCallingEntries(loginToken, dn);
        }
        
        public System.Threading.Tasks.Task<Common.CallingNameV3.CallingNameType[]> GetCallingEntriesAsync(string loginToken, string dn) {
            return base.Channel.GetCallingEntriesAsync(loginToken, dn);
        }
        
        public void InsertCallingEntry(string loginToken, string dn, int bgId, string presentation, string cName) {
            base.Channel.InsertCallingEntry(loginToken, dn, bgId, presentation, cName);
        }
        
        public System.Threading.Tasks.Task InsertCallingEntryAsync(string loginToken, string dn, int bgId, string presentation, string cName) {
            return base.Channel.InsertCallingEntryAsync(loginToken, dn, bgId, presentation, cName);
        }
        
        public void InsertCallingEntries(string loginToken, Common.CallingNameV3.CallingNameType[] entries) {
            base.Channel.InsertCallingEntries(loginToken, entries);
        }
        
        public System.Threading.Tasks.Task InsertCallingEntriesAsync(string loginToken, Common.CallingNameV3.CallingNameType[] entries) {
            return base.Channel.InsertCallingEntriesAsync(loginToken, entries);
        }
        
        public void DeleteCallingEntry(string loginToken, string dn, int bgId) {
            base.Channel.DeleteCallingEntry(loginToken, dn, bgId);
        }
        
        public System.Threading.Tasks.Task DeleteCallingEntryAsync(string loginToken, string dn, int bgId) {
            return base.Channel.DeleteCallingEntryAsync(loginToken, dn, bgId);
        }
        
        public void DeleteCallingEntries(string loginToken, Common.CallingNameV3.CallingNameType[] entries) {
            base.Channel.DeleteCallingEntries(loginToken, entries);
        }
        
        public System.Threading.Tasks.Task DeleteCallingEntriesAsync(string loginToken, Common.CallingNameV3.CallingNameType[] entries) {
            return base.Channel.DeleteCallingEntriesAsync(loginToken, entries);
        }
        
        public Common.CallingNameV3.ScreenPopType[] GetAllScreenPopEntries(string loginToken) {
            return base.Channel.GetAllScreenPopEntries(loginToken);
        }
        
        public System.Threading.Tasks.Task<Common.CallingNameV3.ScreenPopType[]> GetAllScreenPopEntriesAsync(string loginToken) {
            return base.Channel.GetAllScreenPopEntriesAsync(loginToken);
        }
        
        public void InsertScreenPopEntry(string loginToken, string npaNxx, string description) {
            base.Channel.InsertScreenPopEntry(loginToken, npaNxx, description);
        }
        
        public System.Threading.Tasks.Task InsertScreenPopEntryAsync(string loginToken, string npaNxx, string description) {
            return base.Channel.InsertScreenPopEntryAsync(loginToken, npaNxx, description);
        }
        
        public void DeleteScreenPopEntry(string loginToken, string npaNxx) {
            base.Channel.DeleteScreenPopEntry(loginToken, npaNxx);
        }
        
        public System.Threading.Tasks.Task DeleteScreenPopEntryAsync(string loginToken, string npaNxx) {
            return base.Channel.DeleteScreenPopEntryAsync(loginToken, npaNxx);
        }
        
        public void InsertScreenPopSubscriber(string loginToken, string calledNumber, bool videoScreenPopEnabled) {
            base.Channel.InsertScreenPopSubscriber(loginToken, calledNumber, videoScreenPopEnabled);
        }
        
        public System.Threading.Tasks.Task InsertScreenPopSubscriberAsync(string loginToken, string calledNumber, bool videoScreenPopEnabled) {
            return base.Channel.InsertScreenPopSubscriberAsync(loginToken, calledNumber, videoScreenPopEnabled);
        }
        
        public Common.CallingNameV3.ScreenPopSubscriberType[] GetAllNetEchoSubscribers(string loginToken, string npaNxx) {
            return base.Channel.GetAllNetEchoSubscribers(loginToken, npaNxx);
        }
        
        public System.Threading.Tasks.Task<Common.CallingNameV3.ScreenPopSubscriberType[]> GetAllNetEchoSubscribersAsync(string loginToken, string npaNxx) {
            return base.Channel.GetAllNetEchoSubscribersAsync(loginToken, npaNxx);
        }
        
        public Common.CallingNameV3.ScreenPopSubscriberType GetNetEchoSubscriber(string loginToken, string phoneNumber) {
            return base.Channel.GetNetEchoSubscriber(loginToken, phoneNumber);
        }
        
        public System.Threading.Tasks.Task<Common.CallingNameV3.ScreenPopSubscriberType> GetNetEchoSubscriberAsync(string loginToken, string phoneNumber) {
            return base.Channel.GetNetEchoSubscriberAsync(loginToken, phoneNumber);
        }
        
        public void DeleteScreenPopSubscriber(string loginToken, string calledNumber) {
            base.Channel.DeleteScreenPopSubscriber(loginToken, calledNumber);
        }
        
        public System.Threading.Tasks.Task DeleteScreenPopSubscriberAsync(string loginToken, string calledNumber) {
            return base.Channel.DeleteScreenPopSubscriberAsync(loginToken, calledNumber);
        }
    }
}
