using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace MyPhotos.Model
{
    [DataContract(IsReference = true)]
    public class File
    {
        [DataMember]
        public Guid FileId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
        [DataMember]
        public ICollection<FileData> FileDatas { get; set; }

        public File()
        {
            this.FileId = Guid.NewGuid();
        }

        public File(string name, string path, Nullable<DateTime> createdAt = null)
        {
            this.FileId = Guid.NewGuid();
            this.Name = name;
            this.Path = path;
            this.CreatedAt = createdAt ?? DateTime.Now;

        }

        public override string ToString()
        {
            return $"File {this.FileId}: -name: {this.Name} -path: {this.Path}\n";
        }
    }
}
