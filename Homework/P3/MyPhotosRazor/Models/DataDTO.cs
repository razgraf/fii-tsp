using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosRazor.Models
{
    public class DataDTO
    {
        public Guid DataId { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }

        public bool IsEditable { get; set; }
        public DateTime CreatedAt { get; set; }

        public DataDTO()
        {
            
        }
        public DataDTO(ServiceFresh.Data data)
        {
            this.DataId = data.DataId;
            this.IsEditable = data.IsEditable;
            this.Label = data.Label;
            this.Type = data.Type;
            this.CreatedAt = data.CreatedAt;
        }
    }
}
