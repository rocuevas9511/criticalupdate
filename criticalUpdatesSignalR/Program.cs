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
            Console.ReadLine();
            CriticalUpdateSignalRClient.Connect();
            CriticalUpdateSignalRClient.joinAppType();
            Console.ReadLine();
            CriticalUpdateSignalRClient.pushUpdate();
            Console.ReadLine();
        }
    }

}
