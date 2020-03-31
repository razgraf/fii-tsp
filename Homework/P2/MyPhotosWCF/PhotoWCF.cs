using MyPhotos.Model;
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

        MyPhotos.Storage.DbService DbService;

        public PhotoWCF()
        {
            this.DbService = new MyPhotos.Storage.DbService();
        }

        public Data CreateData(string label, bool isSearchable = true)
        {
            return this.DbService.CreateData(label, isSearchable);
     
        }

        public File CreateFile(string name, string path)
        {
            return this.DbService.CreateFile(name, path);
        }

        public FileData CreateFileData(File file, Data data, string value)
        {
            return this.DbService.CreateFileData(file, data, value);
        }

        public Data GetDataById(Guid id)
        {
            return this.DbService.GetDataById(id);
        }

        public List<Data> GetDatas()
        {
            return this.DbService.GetDatas();
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

        public List<File> GetFiles()
        {
            return this.DbService.GetFiles();
        }

        public List<Data> GetFilteredDatas(Func<Data, bool> filter)
        {
            return this.DbService.GetFilteredDatas(filter);
        }

        public List<FileData> GetFilteredFileDatas(Func<FileData, bool> filter)
        {
            return this.DbService.GetFilteredFileDatas(filter);
        }

        public List<File> GetFilteredFiles(Func<File, bool> filter)
        {
            return this.DbService.GetFilteredFiles(filter);
        }

        public void RemoveDataById(Guid id)
        {
            this.DbService.RemoveDataById(id);
        }

        public void RemoveFileById(Guid id)
        {
            this.DbService.RemoveFileById(id);
        }

        public void UpdateFileDataByFileIdAndLabel(Guid fileId, string label, string value)
        {
            this.DbService.UpdateFileDataByFileIdAndLabel(fileId, label, value);
        }
    }
}
