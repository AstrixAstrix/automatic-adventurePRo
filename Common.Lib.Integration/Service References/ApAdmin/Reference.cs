﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.ApAdmin {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginInformation", Namespace="http://schemas.datacontract.org/2004/07/LoginService")]
    [System.SerializableAttribute()]
    public partial class LoginInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApIpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginTokenField;
        
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
        public string ApIpAddress {
            get {
                return this.ApIpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ApIpAddressField, value) != true)) {
                    this.ApIpAddressField = value;
                    this.RaisePropertyChanged("ApIpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginToken {
            get {
                return this.LoginTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginTokenField, value) != true)) {
                    this.LoginTokenField = value;
                    this.RaisePropertyChanged("LoginToken");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApAdmin.IApAdmin")]
    public interface IApAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApAdmin/Login", ReplyAction="http://tempuri.org/IApAdmin/LoginResponse")]
        string Login(string systemKey, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApAdmin/Login", ReplyAction="http://tempuri.org/IApAdmin/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string systemKey, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApAdmin/LoginAdv", ReplyAction="http://tempuri.org/IApAdmin/LoginAdvResponse")]
        Common.ApAdmin.LoginInformation LoginAdv(string systemKey, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApAdmin/LoginAdv", ReplyAction="http://tempuri.org/IApAdmin/LoginAdvResponse")]
        System.Threading.Tasks.Task<Common.ApAdmin.LoginInformation> LoginAdvAsync(string systemKey, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApAdmin/Logout", ReplyAction="http://tempuri.org/IApAdmin/LogoutResponse")]
        void Logout(string loginToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApAdmin/Logout", ReplyAction="http://tempuri.org/IApAdmin/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(string loginToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApAdminChannel : Common.ApAdmin.IApAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApAdminClient : System.ServiceModel.ClientBase<Common.ApAdmin.IApAdmin>, Common.ApAdmin.IApAdmin {
        
        public ApAdminClient() {
        }
        
        public ApAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(string systemKey, string username, string password) {
            return base.Channel.Login(systemKey, username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string systemKey, string username, string password) {
            return base.Channel.LoginAsync(systemKey, username, password);
        }
        
        public Common.ApAdmin.LoginInformation LoginAdv(string systemKey, string username, string password) {
            return base.Channel.LoginAdv(systemKey, username, password);
        }
        
        public System.Threading.Tasks.Task<Common.ApAdmin.LoginInformation> LoginAdvAsync(string systemKey, string username, string password) {
            return base.Channel.LoginAdvAsync(systemKey, username, password);
        }
        
        public void Logout(string loginToken) {
            base.Channel.Logout(loginToken);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string loginToken) {
            return base.Channel.LogoutAsync(loginToken);
        }
    }
}
