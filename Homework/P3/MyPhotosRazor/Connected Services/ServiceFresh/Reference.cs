﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceFresh
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class File : object
    {
        
        private System.DateTime CreatedAtField;
        
        private System.Collections.Generic.List<ServiceFresh.FileData> FileDatasField;
        
        private System.Guid FileIdField;
        
        private string NameField;
        
        private string PathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceFresh.FileData> FileDatas
        {
            get
            {
                return this.FileDatasField;
            }
            set
            {
                this.FileDatasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileData", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class FileData : object
    {
        
        private System.DateTime CreatedAtField;
        
        private ServiceFresh.Data DataField;
        
        private System.Guid DataIdField;
        
        private ServiceFresh.File FileField;
        
        private System.Guid FileDataIdField;
        
        private System.Guid FileIdField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceFresh.Data Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid DataId
        {
            get
            {
                return this.DataIdField;
            }
            set
            {
                this.DataIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceFresh.File File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid FileDataId
        {
            get
            {
                return this.FileDataIdField;
            }
            set
            {
                this.FileDataIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos", IsReference=true)]
    public partial class Data : object
    {
        
        private System.DateTime CreatedAtField;
        
        private System.Guid DataIdField;
        
        private System.Collections.Generic.List<ServiceFresh.FileData> FileDatasField;
        
        private bool IsEditableField;
        
        private bool IsSearchableField;
        
        private string LabelField;
        
        private string SourceField;
        
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid DataId
        {
            get
            {
                return this.DataIdField;
            }
            set
            {
                this.DataIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceFresh.FileData> FileDatas
        {
            get
            {
                return this.FileDatasField;
            }
            set
            {
                this.FileDatasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEditable
        {
            get
            {
                return this.IsEditableField;
            }
            set
            {
                this.IsEditableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSearchable
        {
            get
            {
                return this.IsSearchableField;
            }
            set
            {
                this.IsSearchableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Label
        {
            get
            {
                return this.LabelField;
            }
            set
            {
                this.LabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source
        {
            get
            {
                return this.SourceField;
            }
            set
            {
                this.SourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceFresh.InterfaceWCF")]
    public interface InterfaceWCF
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFiles", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.File>> GetFilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileById", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileByIdResponse")]
        System.Threading.Tasks.Task<ServiceFresh.File> GetFileByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileDatasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.FileData>> GetFileDatasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileDatasByFileId", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileDatasByFileIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.FileData>> GetFileDatasByFileIdAsync(System.Guid fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetDatasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.Data>> GetDatasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetDataById", ReplyAction="http://tempuri.org/InterfaceWCF/GetDataByIdResponse")]
        System.Threading.Tasks.Task<ServiceFresh.Data> GetDataByIdAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface InterfaceWCFChannel : ServiceFresh.InterfaceWCF, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class InterfaceWCFClient : System.ServiceModel.ClientBase<ServiceFresh.InterfaceWCF>, ServiceFresh.InterfaceWCF
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InterfaceWCFClient() : 
                base(InterfaceWCFClient.GetDefaultBinding(), InterfaceWCFClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_InterfaceWCF.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(EndpointConfiguration endpointConfiguration) : 
                base(InterfaceWCFClient.GetBindingForEndpoint(endpointConfiguration), InterfaceWCFClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InterfaceWCFClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InterfaceWCFClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfaceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.File>> GetFilesAsync()
        {
            return base.Channel.GetFilesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceFresh.File> GetFileByIdAsync(System.Guid id)
        {
            return base.Channel.GetFileByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.FileData>> GetFileDatasAsync()
        {
            return base.Channel.GetFileDatasAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.FileData>> GetFileDatasByFileIdAsync(System.Guid fileId)
        {
            return base.Channel.GetFileDatasByFileIdAsync(fileId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceFresh.Data>> GetDatasAsync()
        {
            return base.Channel.GetDatasAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceFresh.Data> GetDataByIdAsync(System.Guid id)
        {
            return base.Channel.GetDataByIdAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfaceWCF))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfaceWCF))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8081/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InterfaceWCFClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_InterfaceWCF);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InterfaceWCFClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_InterfaceWCF);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_InterfaceWCF,
        }
    }
}