using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RacingDriverService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(RacingService)))
            {
                host.Open();

                foreach (var ep in host.Description.Endpoints)
                {
                    Console.WriteLine(ep.Address);
                }

                Console.ReadKey();
            }
        }
    }
}
