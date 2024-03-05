using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.Internet
{
    public class InternetConnectionChecker
    {
        public static bool IsInternetAvailable()
        {
            try
            {
                // Ping Google's public DNS server (8.8.8.8)
                Ping ping = new Ping();
                PingReply reply = ping.Send("8.8.8.8", 1000); // 1000 milliseconds timeout

                return reply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
