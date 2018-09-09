using System;
using System.Net;

namespace CdrFacturaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls;
            using (var service = new ServiceReference1.billServiceClient())
            {
                var result = service.getStatus("201234567891", "01", "F001", 200);
                Console.WriteLine("StatuCode :" + result.statusCode + " -> " + result.statusMessage);
                Console.ReadKey();
            }
        }
    }
}
