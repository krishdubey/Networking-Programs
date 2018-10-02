using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ClintApplication
{
    class MyClient
    {
        public static void Main()
        {
            IPHostEntry IPHost = Dns.Resolve("www.hotmail.com");
            Console.WriteLine(IPHost.HostName);
            string[] aliases = IPHost.Aliases;
            Console.WriteLine(aliases.Length);
            IPAddress[] addr = IPHost.AddressList;
            Console.WriteLine(addr.Length);
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine(addr[i]);
            }
        }
    }
}
