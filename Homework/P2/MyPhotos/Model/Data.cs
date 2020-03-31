using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyPhotos.Model
{
    [DataContract(IsReference = true)]
    public class Data
    {

        [DataMember]
        public Guid DataId { get; set; }
        [DataMember]
        public string Label { get; set; }
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public bool IsEditable { get; set; }
        [DataMember]
        public bool IsSearchable { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
        [DataMember]

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
