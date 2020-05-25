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
        List<File> GetFiles();

        [OperationContract]
        File GetFileById(Guid id);

        [OperationContract]
        List<FileData> GetFileDatas();

        [OperationContract]
        List<FileData> GetFileDatasByFileId(Guid fileId);

        [OperationContract]
        List<Data> GetDatas();

        [OperationContract]
        Data GetDataById(Guid id);
    }

}
