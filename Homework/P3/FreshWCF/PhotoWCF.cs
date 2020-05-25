using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyPhotos;

namespace MyPhotosWCF
{
    public class PhotoWCF : InterfaceWCF
    {

        DbService DbService;

        public PhotoWCF()
        {
            this.DbService = new DbService();
        }
      
        public List<File> GetFiles()
        {
            return this.DbService.GetFiles();
        }

        public File GetFileById(Guid id)
        {
            return this.DbService.GetFileById(id);
        }

        public List<FileData> GetFileDatas()
        {
            return this.DbService.GetFileDatas();
        }

        public List<FileData> GetFileDatasByFileId(Guid fileId)
        {
            return this.DbService.GetFileDatasByFileId(fileId);
        }

        public Data GetDataById(Guid id)
        {
            return this.DbService.GetDataById(id);
        }

        public List<Data> GetDatas()
        {
            return this.DbService.GetDatas();
        }


    }
}
