using Microsoft.Owin.Hosting;
using System;
using System.Threading;

namespace WebApiDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://*:80/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}
