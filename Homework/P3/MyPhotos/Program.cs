﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyPhotos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");
            DbService dbService = new DbService();
           /* dbService.InitDb();*/

        
            Console.ReadKey();

        }
    }
}
