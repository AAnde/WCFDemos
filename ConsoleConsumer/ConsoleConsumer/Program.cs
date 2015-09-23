using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.SampleServiceClient httpobj = new ServiceReference1.SampleServiceClient("BasicHttpBinding_ISampleService");
            ServiceReference1.PublicServiceClient nettcpobj = new ServiceReference1.PublicServiceClient("NetTcpBinding_IPublicService");
            Console.WriteLine(httpobj.GetMessage("Ashok"));
            Console.WriteLine(nettcpobj.GetMessage1());
            Console.ReadLine();
        }
    }
}
