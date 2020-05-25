using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosRazor.Models
{
    public class FileDataDTO
    {
        public Guid FileDataId { get; set; }
        public Guid FileId { get; set; }
        public Guid DataId { get; set; }

        public string DataName { get; set; }

        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }

        public FileDataDTO()
        {
            
        }
        public FileDataDTO(ServiceFresh.FileData rel)
        {
            this.FileDataId = rel.FileDataId;
            this.FileId = rel.FileDataId;
            this.DataId = rel.DataId;
            this.Value = rel.Value;
            this.CreatedAt = rel.CreatedAt;
        }
    }
}
