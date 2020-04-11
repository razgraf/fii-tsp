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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
         
            Service.InterfaceWCFClient client = new Service.InterfaceWCFClient();
/*
            client.GetFiles();*/
            /*
                        var remoteAddress = new System.ServiceModel.EndpointAddress("http://localhost:8080/PC");

                        using (var productService = new InterfaceWCFClient(new System.ServiceModel.BasicHttpBinding(), remoteAddress))
                        {
                            //set timeout
                            productService.Endpoint.Binding.SendTimeout = new TimeSpan(0, 0, 0, 5);

                            //call web service method
                             productService.GetFiles();
                        }

                        Console.ReadLine();*/
        }
    }
}
