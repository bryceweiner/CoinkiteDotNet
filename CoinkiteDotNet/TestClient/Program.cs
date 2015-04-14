﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinkiteDotNet;

namespace TestClient
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            ICoinKite test = new ICoinKiteService("K4b092859-55e83adc-de62977147d346f4", "S097472f9-a831bd74-d730c43d58b79652");
            User output = test.registerUser();

            System.Console.WriteLine(output.apikey);
            System.Console.ReadLine();
        }
    }
}
