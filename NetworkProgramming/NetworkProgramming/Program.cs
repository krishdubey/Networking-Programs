using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NetworkProgramming
{
    class Program
    {
        static void Main()
        {
            String strHostName = string.Empty; //getting the Host Name.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);// Using Host Name,IP address is obtained.
            IPAddress[] addr = ipEntry.AddressList;
        //    Console.WriteLine(addr[2]);
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address : "+ addr[i]);
            }
            Console.ReadLine();
        }
    }
}
