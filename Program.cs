﻿using System;
using Nancy.Hosting.Self;

namespace SimpleNancyExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var uri = new Uri("http://localhost:8210");
            var conf = new HostConfiguration();
            conf.UrlReservations.CreateAutomatically = true;

            var host = new NancyHost(conf, uri);

            host.Start();

            Console.WriteLine("Your application is running on " + uri);
            Console.WriteLine("Press any key followed by [Enter] to close the host.");
            Console.ReadLine();
        }
    }
}
