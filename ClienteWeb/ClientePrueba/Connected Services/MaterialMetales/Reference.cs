﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWeb.MaterialMetales {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Metales", Namespace="http://schemas.datacontract.org/2004/07/WSMateriales.Entidades")]
    [System.SerializableAttribute()]
    public partial class Metales : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MateriaPrimaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MineralField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SemiFabricadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_metalField;
        
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
        public System.Nullable<int> Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MateriaPrima {
            get {
                return this.MateriaPrimaField;
            }
            set {
                if ((object.ReferenceEquals(this.MateriaPrimaField, value) != true)) {
                    this.MateriaPrimaField = value;
                    this.RaisePropertyChanged("MateriaPrima");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mineral {
            get {
                return this.MineralField;
            }
            set {
                if ((object.ReferenceEquals(this.MineralField, value) != true)) {
                    this.MineralField = value;
                    this.RaisePropertyChanged("Mineral");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SemiFabricado {
            get {
                return this.SemiFabricadoField;
            }
            set {
                if ((object.ReferenceEquals(this.SemiFabricadoField, value) != true)) {
                    this.SemiFabricadoField = value;
                    this.RaisePropertyChanged("SemiFabricado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_metal {
            get {
                return this.id_metalField;
            }
            set {
                if ((this.id_metalField.Equals(value) != true)) {
                    this.id_metalField = value;
                    this.RaisePropertyChanged("id_metal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MaterialMetales.IMaterialMetal")]
    public interface IMaterialMetal {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/BuscarTodos", ReplyAction="http://tempuri.org/IMaterialMetal/BuscarTodosResponse")]
        ClienteWeb.MaterialMetales.Metales[] BuscarTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/BuscarTodos", ReplyAction="http://tempuri.org/IMaterialMetal/BuscarTodosResponse")]
        System.Threading.Tasks.Task<ClienteWeb.MaterialMetales.Metales[]> BuscarTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/BucarId", ReplyAction="http://tempuri.org/IMaterialMetal/BucarIdResponse")]
        ClienteWeb.MaterialMetales.Metales BucarId(string id_metal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/BucarId", ReplyAction="http://tempuri.org/IMaterialMetal/BucarIdResponse")]
        System.Threading.Tasks.Task<ClienteWeb.MaterialMetales.Metales> BucarIdAsync(string id_metal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/Create", ReplyAction="http://tempuri.org/IMaterialMetal/CreateResponse")]
        bool Create(ClienteWeb.MaterialMetales.Metales metales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/Create", ReplyAction="http://tempuri.org/IMaterialMetal/CreateResponse")]
        System.Threading.Tasks.Task<bool> CreateAsync(ClienteWeb.MaterialMetales.Metales metales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/Edit", ReplyAction="http://tempuri.org/IMaterialMetal/EditResponse")]
        void Edit(ClienteWeb.MaterialMetales.Metales metales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/Edit", ReplyAction="http://tempuri.org/IMaterialMetal/EditResponse")]
        System.Threading.Tasks.Task EditAsync(ClienteWeb.MaterialMetales.Metales metales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/Delete", ReplyAction="http://tempuri.org/IMaterialMetal/DeleteResponse")]
        bool Delete(ClienteWeb.MaterialMetales.Metales metales);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaterialMetal/Delete", ReplyAction="http://tempuri.org/IMaterialMetal/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(ClienteWeb.MaterialMetales.Metales metales);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMaterialMetalChannel : ClienteWeb.MaterialMetales.IMaterialMetal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MaterialMetalClient : System.ServiceModel.ClientBase<ClienteWeb.MaterialMetales.IMaterialMetal>, ClienteWeb.MaterialMetales.IMaterialMetal {
        
        public MaterialMetalClient() {
        }
        
        public MaterialMetalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MaterialMetalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaterialMetalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaterialMetalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteWeb.MaterialMetales.Metales[] BuscarTodos() {
            return base.Channel.BuscarTodos();
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.MaterialMetales.Metales[]> BuscarTodosAsync() {
            return base.Channel.BuscarTodosAsync();
        }
        
        public ClienteWeb.MaterialMetales.Metales BucarId(string id_metal) {
            return base.Channel.BucarId(id_metal);
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.MaterialMetales.Metales> BucarIdAsync(string id_metal) {
            return base.Channel.BucarIdAsync(id_metal);
        }
        
        public bool Create(ClienteWeb.MaterialMetales.Metales metales) {
            return base.Channel.Create(metales);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAsync(ClienteWeb.MaterialMetales.Metales metales) {
            return base.Channel.CreateAsync(metales);
        }
        
        public void Edit(ClienteWeb.MaterialMetales.Metales metales) {
            base.Channel.Edit(metales);
        }
        
        public System.Threading.Tasks.Task EditAsync(ClienteWeb.MaterialMetales.Metales metales) {
            return base.Channel.EditAsync(metales);
        }
        
        public bool Delete(ClienteWeb.MaterialMetales.Metales metales) {
            return base.Channel.Delete(metales);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(ClienteWeb.MaterialMetales.Metales metales) {
            return base.Channel.DeleteAsync(metales);
        }
    }
}
