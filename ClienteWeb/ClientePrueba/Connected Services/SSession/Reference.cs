﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientePrueba.SSession {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WSMateriales.Entidades")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
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
        public string Clave {
            get {
                return this.ClaveField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaveField, value) != true)) {
                    this.ClaveField = value;
                    this.RaisePropertyChanged("Clave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SSession.IServicioLogin")]
    public interface IServicioLogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLogin/Desconectar", ReplyAction="http://tempuri.org/IServicioLogin/DesconectarResponse")]
        bool Desconectar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLogin/Desconectar", ReplyAction="http://tempuri.org/IServicioLogin/DesconectarResponse")]
        System.Threading.Tasks.Task<bool> DesconectarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLogin/Conectar", ReplyAction="http://tempuri.org/IServicioLogin/ConectarResponse")]
        bool Conectar(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLogin/Conectar", ReplyAction="http://tempuri.org/IServicioLogin/ConectarResponse")]
        System.Threading.Tasks.Task<bool> ConectarAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLogin/BuscarPorMail", ReplyAction="http://tempuri.org/IServicioLogin/BuscarPorMailResponse")]
        ClientePrueba.SSession.Usuario BuscarPorMail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLogin/BuscarPorMail", ReplyAction="http://tempuri.org/IServicioLogin/BuscarPorMailResponse")]
        System.Threading.Tasks.Task<ClientePrueba.SSession.Usuario> BuscarPorMailAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioLoginChannel : ClientePrueba.SSession.IServicioLogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioLoginClient : System.ServiceModel.ClientBase<ClientePrueba.SSession.IServicioLogin>, ClientePrueba.SSession.IServicioLogin {
        
        public ServicioLoginClient() {
        }
        
        public ServicioLoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioLoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioLoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioLoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Desconectar() {
            return base.Channel.Desconectar();
        }
        
        public System.Threading.Tasks.Task<bool> DesconectarAsync() {
            return base.Channel.DesconectarAsync();
        }
        
        public bool Conectar(string email, string password) {
            return base.Channel.Conectar(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> ConectarAsync(string email, string password) {
            return base.Channel.ConectarAsync(email, password);
        }
        
        public ClientePrueba.SSession.Usuario BuscarPorMail(string email) {
            return base.Channel.BuscarPorMail(email);
        }
        
        public System.Threading.Tasks.Task<ClientePrueba.SSession.Usuario> BuscarPorMailAsync(string email) {
            return base.Channel.BuscarPorMailAsync(email);
        }
    }
}