using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Model
{
    public class FileData
    {
        public Guid FileDataId { get; set; }
        public Guid FileId { get; set; }
        public Guid DataId { get; set; }
        public File File { get; set; }
        public Data Data { get; set; }
        public string Value { get; set; }
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
