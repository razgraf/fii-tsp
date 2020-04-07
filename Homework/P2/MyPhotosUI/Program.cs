using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*       Application.EnableVisualStyles();
                   Application.SetCompatibleTextRenderingDefault(false);
                   Application.Run(new Dashboard());*/
            /*
            InterfaceWCFClient client = new InterfaceWCFClient("BasicHttpBinding_InterfaceWCF");*/
            Service.InterfaceWCFClient client = new Service.InterfaceWCFClient();

            client.GetFiles();


            Console.ReadLine();
        }
    }
}
