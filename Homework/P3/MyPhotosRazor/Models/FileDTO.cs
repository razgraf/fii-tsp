using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosRazor.Models
{
    public class FileDTO
    {
        public Guid FileId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }

        public FileDTO()
        {
            
        }
        public FileDTO(ServiceFresh.File file)
        {

            this.FileId = file.FileId;
            this.Name = file.Name;
            this.Path = file.Path;
            this.CreatedAt = file.CreatedAt;
        }
    }
}
