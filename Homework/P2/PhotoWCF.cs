﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos.Model
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.Model", IsReference=true)]
    public partial class File : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime CreatedAtField;
        
        private MyPhotos.Model.FileData[] FileDatasField;
        
        private System.Guid FileIdField;
        
        private string NameField;
        
        private string PathField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public MyPhotos.Model.FileData[] FileDatas
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileData", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.Model", IsReference=true)]
    public partial class FileData : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime CreatedAtField;
        
        private MyPhotos.Model.Data DataField;
        
        private System.Guid DataIdField;
        
        private MyPhotos.Model.File FileField;
        
        private System.Guid FileDataIdField;
        
        private System.Guid FileIdField;
        
        private string ValueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public MyPhotos.Model.Data Data
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
        public MyPhotos.Model.File File
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data", Namespace="http://schemas.datacontract.org/2004/07/MyPhotos.Model", IsReference=true)]
    public partial class Data : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime CreatedAtField;
        
        private System.Guid DataIdField;
        
        private MyPhotos.Model.FileData[] FileDatasField;
        
        private bool IsEditableField;
        
        private bool IsSearchableField;
        
        private string LabelField;
        
        private string SourceField;
        
        private string TypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public MyPhotos.Model.FileData[] FileDatas
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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="InterfaceWCF")]
public interface InterfaceWCF
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/UpdateFileDataByFileIdAndLabel", ReplyAction="http://tempuri.org/InterfaceWCF/UpdateFileDataByFileIdAndLabelResponse")]
    void UpdateFileDataByFileIdAndLabel(System.Guid fileId, string label, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/UpdateFileDataByFileIdAndLabel", ReplyAction="http://tempuri.org/InterfaceWCF/UpdateFileDataByFileIdAndLabelResponse")]
    System.Threading.Tasks.Task UpdateFileDataByFileIdAndLabelAsync(System.Guid fileId, string label, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateFile", ReplyAction="http://tempuri.org/InterfaceWCF/CreateFileResponse")]
    MyPhotos.Model.File CreateFile(string name, string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateFile", ReplyAction="http://tempuri.org/InterfaceWCF/CreateFileResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.File> CreateFileAsync(string name, string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateData", ReplyAction="http://tempuri.org/InterfaceWCF/CreateDataResponse")]
    MyPhotos.Model.Data CreateData(string label, bool isSearchable);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateData", ReplyAction="http://tempuri.org/InterfaceWCF/CreateDataResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.Data> CreateDataAsync(string label, bool isSearchable);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateFileData", ReplyAction="http://tempuri.org/InterfaceWCF/CreateFileDataResponse")]
    MyPhotos.Model.FileData CreateFileData(MyPhotos.Model.File file, MyPhotos.Model.Data data, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/CreateFileData", ReplyAction="http://tempuri.org/InterfaceWCF/CreateFileDataResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.FileData> CreateFileDataAsync(MyPhotos.Model.File file, MyPhotos.Model.Data data, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/RemoveFileById", ReplyAction="http://tempuri.org/InterfaceWCF/RemoveFileByIdResponse")]
    void RemoveFileById(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/RemoveFileById", ReplyAction="http://tempuri.org/InterfaceWCF/RemoveFileByIdResponse")]
    System.Threading.Tasks.Task RemoveFileByIdAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/RemoveDataById", ReplyAction="http://tempuri.org/InterfaceWCF/RemoveDataByIdResponse")]
    void RemoveDataById(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/RemoveDataById", ReplyAction="http://tempuri.org/InterfaceWCF/RemoveDataByIdResponse")]
    System.Threading.Tasks.Task RemoveDataByIdAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileById", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileByIdResponse")]
    MyPhotos.Model.File GetFileById(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileById", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileByIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.File> GetFileByIdAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetDataById", ReplyAction="http://tempuri.org/InterfaceWCF/GetDataByIdResponse")]
    MyPhotos.Model.Data GetDataById(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetDataById", ReplyAction="http://tempuri.org/InterfaceWCF/GetDataByIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.Data> GetDataByIdAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFiles", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilesResponse")]
    MyPhotos.Model.File[] GetFiles();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFiles", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilesResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.File[]> GetFilesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetDatasResponse")]
    MyPhotos.Model.Data[] GetDatas();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetDatasResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.Data[]> GetDatasAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileDatasResponse")]
    MyPhotos.Model.FileData[] GetFileDatas();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileDatasResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.FileData[]> GetFileDatasAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileDatasByFileId", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileDatasByFileIdResponse")]
    MyPhotos.Model.FileData[] GetFileDatasByFileId(System.Guid fileId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFileDatasByFileId", ReplyAction="http://tempuri.org/InterfaceWCF/GetFileDatasByFileIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.FileData[]> GetFileDatasByFileIdAsync(System.Guid fileId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFilteredFiles", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilteredFilesResponse")]
    MyPhotos.Model.File[] GetFilteredFiles(System.Func<MyPhotos.Model.File, bool> filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFilteredFiles", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilteredFilesResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.File[]> GetFilteredFilesAsync(System.Func<MyPhotos.Model.File, bool> filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFilteredDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilteredDatasResponse")]
    MyPhotos.Model.Data[] GetFilteredDatas(System.Func<MyPhotos.Model.Data, bool> filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFilteredDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilteredDatasResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.Data[]> GetFilteredDatasAsync(System.Func<MyPhotos.Model.Data, bool> filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFilteredFileDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilteredFileDatasResponse")]
    MyPhotos.Model.FileData[] GetFilteredFileDatas(System.Func<MyPhotos.Model.FileData, bool> filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWCF/GetFilteredFileDatas", ReplyAction="http://tempuri.org/InterfaceWCF/GetFilteredFileDatasResponse")]
    System.Threading.Tasks.Task<MyPhotos.Model.FileData[]> GetFilteredFileDatasAsync(System.Func<MyPhotos.Model.FileData, bool> filter);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface InterfaceWCFChannel : InterfaceWCF, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class InterfaceWCFClient : System.ServiceModel.ClientBase<InterfaceWCF>, InterfaceWCF
{
    
    public InterfaceWCFClient()
    {
    }
    
    public InterfaceWCFClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public InterfaceWCFClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public InterfaceWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public InterfaceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void UpdateFileDataByFileIdAndLabel(System.Guid fileId, string label, string value)
    {
        base.Channel.UpdateFileDataByFileIdAndLabel(fileId, label, value);
    }
    
    public System.Threading.Tasks.Task UpdateFileDataByFileIdAndLabelAsync(System.Guid fileId, string label, string value)
    {
        return base.Channel.UpdateFileDataByFileIdAndLabelAsync(fileId, label, value);
    }
    
    public MyPhotos.Model.File CreateFile(string name, string path)
    {
        return base.Channel.CreateFile(name, path);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.File> CreateFileAsync(string name, string path)
    {
        return base.Channel.CreateFileAsync(name, path);
    }
    
    public MyPhotos.Model.Data CreateData(string label, bool isSearchable)
    {
        return base.Channel.CreateData(label, isSearchable);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.Data> CreateDataAsync(string label, bool isSearchable)
    {
        return base.Channel.CreateDataAsync(label, isSearchable);
    }
    
    public MyPhotos.Model.FileData CreateFileData(MyPhotos.Model.File file, MyPhotos.Model.Data data, string value)
    {
        return base.Channel.CreateFileData(file, data, value);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.FileData> CreateFileDataAsync(MyPhotos.Model.File file, MyPhotos.Model.Data data, string value)
    {
        return base.Channel.CreateFileDataAsync(file, data, value);
    }
    
    public void RemoveFileById(System.Guid id)
    {
        base.Channel.RemoveFileById(id);
    }
    
    public System.Threading.Tasks.Task RemoveFileByIdAsync(System.Guid id)
    {
        return base.Channel.RemoveFileByIdAsync(id);
    }
    
    public void RemoveDataById(System.Guid id)
    {
        base.Channel.RemoveDataById(id);
    }
    
    public System.Threading.Tasks.Task RemoveDataByIdAsync(System.Guid id)
    {
        return base.Channel.RemoveDataByIdAsync(id);
    }
    
    public MyPhotos.Model.File GetFileById(System.Guid id)
    {
        return base.Channel.GetFileById(id);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.File> GetFileByIdAsync(System.Guid id)
    {
        return base.Channel.GetFileByIdAsync(id);
    }
    
    public MyPhotos.Model.Data GetDataById(System.Guid id)
    {
        return base.Channel.GetDataById(id);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.Data> GetDataByIdAsync(System.Guid id)
    {
        return base.Channel.GetDataByIdAsync(id);
    }
    
    public MyPhotos.Model.File[] GetFiles()
    {
        return base.Channel.GetFiles();
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.File[]> GetFilesAsync()
    {
        return base.Channel.GetFilesAsync();
    }
    
    public MyPhotos.Model.Data[] GetDatas()
    {
        return base.Channel.GetDatas();
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.Data[]> GetDatasAsync()
    {
        return base.Channel.GetDatasAsync();
    }
    
    public MyPhotos.Model.FileData[] GetFileDatas()
    {
        return base.Channel.GetFileDatas();
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.FileData[]> GetFileDatasAsync()
    {
        return base.Channel.GetFileDatasAsync();
    }
    
    public MyPhotos.Model.FileData[] GetFileDatasByFileId(System.Guid fileId)
    {
        return base.Channel.GetFileDatasByFileId(fileId);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.FileData[]> GetFileDatasByFileIdAsync(System.Guid fileId)
    {
        return base.Channel.GetFileDatasByFileIdAsync(fileId);
    }
    
    public MyPhotos.Model.File[] GetFilteredFiles(System.Func<MyPhotos.Model.File, bool> filter)
    {
        return base.Channel.GetFilteredFiles(filter);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.File[]> GetFilteredFilesAsync(System.Func<MyPhotos.Model.File, bool> filter)
    {
        return base.Channel.GetFilteredFilesAsync(filter);
    }
    
    public MyPhotos.Model.Data[] GetFilteredDatas(System.Func<MyPhotos.Model.Data, bool> filter)
    {
        return base.Channel.GetFilteredDatas(filter);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.Data[]> GetFilteredDatasAsync(System.Func<MyPhotos.Model.Data, bool> filter)
    {
        return base.Channel.GetFilteredDatasAsync(filter);
    }
    
    public MyPhotos.Model.FileData[] GetFilteredFileDatas(System.Func<MyPhotos.Model.FileData, bool> filter)
    {
        return base.Channel.GetFilteredFileDatas(filter);
    }
    
    public System.Threading.Tasks.Task<MyPhotos.Model.FileData[]> GetFilteredFileDatasAsync(System.Func<MyPhotos.Model.FileData, bool> filter)
    {
        return base.Channel.GetFilteredFileDatasAsync(filter);
    }
}
