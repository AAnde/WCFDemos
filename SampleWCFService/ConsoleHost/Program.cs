﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SampleWCFService.SampleService)))
            {
                host.Open();
                Console.WriteLine("service started...");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
