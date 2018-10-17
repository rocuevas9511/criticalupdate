using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criticalUpdatesSignalR
{

    static class CriticalUpdateSignalRClient
    {


        private static IHubProxy criticalUpdateProxy;
        private static string hubUrl = ConfigurationManager.AppSettings["signalr"];
        private static Action _reconnect;

        public static void Connect()
        {
            try
            {

                HubConnection connection = new HubConnection(hubUrl);
                criticalUpdateProxy = connection.CreateHubProxy("criticalUpdateHub");
                criticalUpdateProxy.On("criticalUpdate", () =>
                {
                    Console.WriteLine("critical update incoming");
                });
                connection.Start().Wait();
                connection.Closed += _reconnect = () => connection.Start().Wait();
            }
            catch (Exception ex) { throw new ArgumentException("Error joining apptype group", ex); }
        }
        public static void joinAppType()
        {
            try
            {
                string appType = ConfigurationManager.AppSettings["appFriendlyName"];
                string apptype = "b0959b75-2258-48b8-a703-780a8f58c79d";
                criticalUpdateProxy.Invoke("joinAppTypeGroup", apptype).Wait();
            }
            catch (Exception ex) { throw new ArgumentException("Error joining apptype group", ex); }
        }
        public static void pushUpdate()
        {
            try
            {
                string appType = ConfigurationManager.AppSettings["appFriendlyName"];
                string apptype = "b0959b75-2258-48b8-a703-780a8f58c79d";
                criticalUpdateProxy.Invoke("pushCriticalUpdateToAppType", apptype).Wait();
            }
            catch (Exception ex) { throw new ArgumentException("Error joining apptype group", ex); }
        }
    }
}
