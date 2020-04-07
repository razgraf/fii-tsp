using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyPhotos
{
    [DataContract(IsReference = true)]
    public class FileData
    {
        [DataMember]
        public Guid FileDataId { get; set; }
        [DataMember]
        public Guid FileId { get; set; }
        [DataMember]
        public Guid DataId { get; set; }
        [DataMember]
        public File File { get; set; }
        [DataMember]
        public Data Data { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }


        public FileData()
        {
            this.FileDataId = Guid.NewGuid();

        }

        public FileData(File file, Data data, string value, Nullable<DateTime> createdAt = null)
        {
            this.FileDataId = Guid.NewGuid();
            this.File = file;
            this.Data = data;
            this.Value = value;
            this.CreatedAt = createdAt ?? DateTime.Now;
        }

    }
}
