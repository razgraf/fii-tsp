﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Model
{
    public class File
    {

        public Guid FileId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }
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
