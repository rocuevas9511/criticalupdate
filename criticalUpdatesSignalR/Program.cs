using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criticalUpdatesSignalR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("begin");
            Console.ReadLine();
            Console.WriteLine("connecting");
            CriticalUpdateSignalRClient.Connect();
            Console.WriteLine("joining");
            CriticalUpdateSignalRClient.joinAppType();
            Console.WriteLine("readytosend");
            Console.ReadLine();
            CriticalUpdateSignalRClient.pushUpdate();
            Console.WriteLine("sent");
            var a=Console.ReadLine();
            while (a != "x")
            {
                a=Console.ReadLine();
                if (a =="s"){
                    CriticalUpdateSignalRClient.pushUpdate();
                }
            }
        }
    }

}
