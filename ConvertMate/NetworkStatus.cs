using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public class NetworkStatus
    {
        
    // Ping a reliable server to check if there is a response
    // If there is, yey connected
    // else :(
    public static bool IsConnectedToInternet()
    {
        try
        {
            using (Ping ping = new Ping())
            {
                PingReply reply = ping.Send("8.8.8.8", 3000); // Google's public DNS
                return reply.Status == IPStatus.Success;
            }
        }
        catch
        {
            return false;
        }
    }
}
}
