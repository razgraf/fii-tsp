using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Model
{
    public class Data
    {

        public Guid DataId { get; set; }
        public string Label { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSearchable { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<FileData> FileDatas { get; set; }

        public Data()
        {
            this.DataId = Guid.NewGuid();

            this.Source = null;
            this.Type = "string";
            this.IsSearchable = true;
            this.IsEditable = true;
            this.CreatedAt = DateTime.Now;

        }

        public Data(string label, string source = null, string type = "string", bool isEditable = true, bool isSearchable = true, Nullable<DateTime> createdAt = null )
        {
            this.DataId = Guid.NewGuid();
            this.Label = label;
            this.Source = source;
            this.Type = type;
            this.IsEditable = isEditable;
            this.IsSearchable = isSearchable;
            this.CreatedAt = createdAt ?? DateTime.Now;

        }


        public override string ToString()
        {
            return $"Data {this.DataId}: -label: {this.Label} -type: {this.Type} -s: {this.IsSearchable} -e: {this.IsEditable}\n";
        }
    }

}
