using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ObjectWCF;

namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Lansare server WCF...");

            Uri baseAddress = new Uri("http://localhost:8081/PC");


            using (ServiceHost host = new ServiceHost(typeof(PostComment), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);

                foreach (ServiceEndpoint se in host.Description.Endpoints)
                    Console.WriteLine("A (address): {0} \nB (binding): {1} \nC (Contract): {2}\nD (Name): {3}\n", se.Address, se.Binding.Name, se.Contract.Name, se.Name);


                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }



        }
    }
}
