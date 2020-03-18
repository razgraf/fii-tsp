using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyPhotos.Model;
using MyPhotos.Storage;

namespace MyPhotos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");
            DbService dbService = new DbService();
          /*  dbService.InitDb();*/

            List<File> files = dbService.GetFiles();
            foreach (File f in files)
                Console.WriteLine(f.ToString());

            Console.WriteLine("End");
            Console.ReadKey();

        }
    }
}
