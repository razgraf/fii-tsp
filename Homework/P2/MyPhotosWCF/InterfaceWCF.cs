using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

using MyPhotos;

namespace MyPhotosWCF
{
    [ServiceContract]
    interface InterfaceWCF
    {

        [OperationContract]
        void UpdateFileDataByFileIdAndLabel(Guid fileId, string label, string value);

        [OperationContract]
        File CreateFile(string name, string path);

        [OperationContract]
        Data CreateData(string label, bool isSearchable = true);

        [OperationContract]
        FileData CreateFileData(File file, Data data, string value);

        [OperationContract]
        void RemoveFileById(Guid id);

        [OperationContract]
        void RemoveDataById(Guid id);

        [OperationContract]
        File GetFileById(Guid id);

        [OperationContract]
        Data GetDataById(Guid id);

        [OperationContract]
        List<File> GetFiles();

        [OperationContract]
        List<Data> GetDatas();

        [OperationContract]
        List<FileData> GetFileDatas();

        [OperationContract]
        List<FileData> GetFileDatasByFileId(Guid fileId);

        [OperationContract]
        List<File> GetFilteredFiles(Func<File, bool> filter);

        [OperationContract]

        List<Data> GetFilteredDatas(Func<Data, bool> filter);

        [OperationContract]
        List<FileData> GetFilteredFileDatas(Func<FileData, bool> filter);

    }

}
