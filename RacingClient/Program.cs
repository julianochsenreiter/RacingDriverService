using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingClient.RacingDriverServiceRef;

namespace RacingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (RacingServiceClient client = new RacingServiceClient())
            {
                string time = client.GetTime("ferrari");
                Console.WriteLine(time);

                TeamInfo teamInfo = client.GetTeamInfo("ferrari");
                Console.WriteLine(teamInfo);
            }
            Console.ReadKey();
        }
    }
}
