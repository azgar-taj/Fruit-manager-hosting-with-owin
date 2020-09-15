using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFruitManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "http://localhost:8000";
            WebApp.Start<Startup>(url: URL);
            Console.WriteLine("OWIN Started on {0}", URL);
            Console.ReadLine();
        }
    }
}
