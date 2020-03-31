using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using MyPhotos;

namespace MyPhotosWCF
{
    [ServiceContract]
    interface InterfaceWCF
    {

        [OperationContract]
        void UpdateFileDataByFileIdAndLabel(Guid fileId, string label, string value);

        [OperationContract]
        MyPhotos.Model.File CreateFile(string name, string path);

        [OperationContract]
        MyPhotos.Model.Data CreateData(string label, bool isSearchable = true);

        [OperationContract]
        MyPhotos.Model.FileData CreateFileData(MyPhotos.Model.File file, MyPhotos.Model.Data data, string value);

        [OperationContract]
        void RemoveFileById(Guid id);

        [OperationContract]
        void RemoveDataById(Guid id);

        [OperationContract]
        MyPhotos.Model.File GetFileById(Guid id);

        [OperationContract]
        MyPhotos.Model.Data GetDataById(Guid id);

        [OperationContract]
        List<MyPhotos.Model.File> GetFiles();

        [OperationContract]
        List<MyPhotos.Model.Data> GetDatas();

        [OperationContract]
        List<MyPhotos.Model.FileData> GetFileDatas();

        [OperationContract]
        List<MyPhotos.Model.FileData> GetFileDatasByFileId(Guid fileId);

        [OperationContract]
        List<MyPhotos.Model.File> GetFilteredFiles(Func<MyPhotos.Model.File, bool> filter);

        [OperationContract]

        List<MyPhotos.Model.Data> GetFilteredDatas(Func<MyPhotos.Model.Data, bool> filter);

        [OperationContract]
        List<MyPhotos.Model.FileData> GetFilteredFileDatas(Func<MyPhotos.Model.FileData, bool> filter);

    }
}
