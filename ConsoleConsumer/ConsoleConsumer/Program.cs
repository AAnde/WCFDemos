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
            ServiceReference1.SampleServiceClient obj = new ServiceReference1.SampleServiceClient();
            Console.WriteLine(obj.GetMessage("Ashok"));
            Console.ReadLine();
        }
    }
}
