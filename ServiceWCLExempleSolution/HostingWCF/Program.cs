using ServiceWCFExemple.Contracts;
using ServiceWCFExemple.Service;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(TradeService));
                Uri uri = new Uri("http://localhost:8080/trades");

                // Adicionando um contraro , tipo de comunicacao e a url a ser disponiblizada.
                host.AddServiceEndpoint(typeof(ITrade), new BasicHttpBinding(), uri);
                host.Open();

                informationDetails(host);
                Console.ReadLine();
                host.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void informationDetails(ServiceHost serviceHost)
        {
            try
            {
                Console.WriteLine("{0} Servico on", serviceHost.Description.ServiceType);

                foreach (ServiceEndpoint item in serviceHost.Description.Endpoints)
                {
                    Console.WriteLine(item.Address);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
