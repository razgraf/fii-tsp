using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPhotos;

namespace MyPhotos
{
    public class DbService
    {

        readonly Context Context;

        public DbService()
        {
             this.Context = new Context();

             if(!this.Context.FileDatas.Any()) this.InitDb();
        }

        /**
         * API
         */ 



        // API - Update


        public void UpdateFileDataByFileIdAndLabel(Guid fileId, string label, string value)
        {
           
            FileData fileData = GetFilteredFileDatas(fd => fd.Data.Label == label && fd.FileId == fileId).FirstOrDefault();
            if (fileData != null)
            {
                Console.WriteLine(value == null || value.Length == 0 ? "Yes" : "No");
                if (value == null || value.Length == 0)
                {
  
                    Context.Remove(fileData);
                    Context.SaveChanges();
                }
                else
                {
                    fileData.Value = value;
                    Context.Update(fileData);
                    Context.SaveChanges();
                }
              
            }
            else
            {
                if (value == null || value.Length == 0) return;



                Data data = GetFilteredDatas(d => d.Label == label).FirstOrDefault();
                File file = GetFileById(fileId);
                if (data == null || file == null) return;
                FileData newFileData = new FileData(file, data, value);
                Context.Add(newFileData);
                Context.SaveChanges();
            }
         
        }

        // API - Create

        public File CreateFile(string name, string path)
        {
            File file = new File(name, path);
            Context.Add(file);
            Context.SaveChanges();
            Context.Entry(file).State = EntityState.Added;
            return file;
        }

        public Data CreateData(string label, bool isSearchable = true)
        {
            Data data = new Data(label,null,"string", true, isSearchable);
            Context.Add(data);
            Context.SaveChanges();
            Context.Entry(data).State = EntityState.Added;
            return data;
        }

        public FileData CreateFileData(File file, Data data, string value)
        {
            FileData fileData = new FileData(file, data, value);
            Context.Add(fileData);
            Context.SaveChanges();
            Context.Entry(fileData).State = EntityState.Added;
            return fileData;
        }

        // API - Remove

        public void RemoveFileById(Guid id)
        {
            File file = this.GetFileById(id);
            if (file == null) return;

            if (file.FileDatas.Count > 0) foreach (FileData fd in file.FileDatas) Context.Remove(fd);
            Context.Remove(file);
            Context.SaveChanges();
        }

        public void RemoveDataById(Guid id)
        {
            Data data = this.GetDataById(id);
            if (data == null) return;

            if (data.FileDatas != null && data.FileDatas.Count > 0) 
                foreach (FileData fd in data.FileDatas) 
                    Context.Remove(fd);
            Context.Remove(data);
            Context.SaveChanges();
        }

        // API - Retrieve Single

        public File GetFileById(Guid id)
        {
            return GetFilteredFiles(f => f.FileId == id).FirstOrDefault();
        }

        public Data GetDataById(Guid id)
        {
            return GetFilteredDatas(d => d.DataId == id).FirstOrDefault();
        }

        // API - Retrieving List

        public List<File> GetFiles()
        {
            return GetFilteredFiles(f => true);
        }

        public List<Data> GetDatas()
        {
            return GetFilteredDatas(d => true);
        }

        public List<FileData> GetFileDatas()
        {
            return GetFilteredFileDatas(fd => true);
        }

        public List<FileData> GetFileDatasByFileId(Guid fileId)
        {
            return GetFilteredFileDatas(fd => fd.FileId == fileId);
        }


        // API - Filtering

        public List<File> GetFilteredFiles(Func<File, bool> filter)
        {
            return Context.Files.Where(filter).ToList();
        }
        public List<Data> GetFilteredDatas(Func<Data, bool> filter)
        {
            return Context.Datas.Where(filter).ToList();
        }

        public List<FileData> GetFilteredFileDatas(Func<FileData, bool> filter)
        {
            return Context.FileDatas.Where(filter).ToList();
        }

        /**
         * Database Utils
         */

        private Tuple<List<File>, List<Data>, List<FileData>> Seed()
        {
            List<File> files = new List<File>
            {
              /*  new File("file1.jpg", "E:/Pictures/file1.jpg"),
                new File("file2.png", "E:/Pictures/file2.png"),
                new File("file3.png", "E:/Pictures/file3.png"),*/
            };

            List<Data> datas = new List<Data>
            {
                new Data("size", null, "string", false, true),
                new Data("dimension", null, "string", false, true),
                new Data("context","[\"personal\",\"work\",\"trip\",\"fun\",\"other\"]"),
            };


            List<FileData> fileDatas = new List<FileData>
            {
                /*new FileData {File = files[0], Data = datas[0], Value = "20", CreatedAt = DateTime.Now},
                new FileData {File = files[1], Data = datas[0], Value = "10", CreatedAt = DateTime.Now},
                new FileData(files[2], datas[0], "300"),*/
            };



            return new Tuple<List<File>, List<Data>, List<FileData>>(files, datas, fileDatas);
        }

        public void InitDb()
        {
            ClearDb();
            Tuple < List<File>, List<Data>, List<FileData>> seed = Seed();
            foreach (File f in seed.Item1)
                Context.Files.Add(f);
            foreach (Data d in seed.Item2)
                Context.Datas.Add(d);
            foreach (FileData fd in seed.Item3)
                Context.FileDatas.Add(fd);

            Context.SaveChanges();

        }

        private void ClearDb()
        {
            Context.FileDatas.RemoveRange(Context.FileDatas);
            Context.Files.RemoveRange(Context.Files);
            Context.Datas.RemoveRange(Context.Datas);
            Context.SaveChanges();
        }
    }
}
