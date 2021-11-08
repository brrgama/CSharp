using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GeneralLibrary;

namespace GeneralConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = FuncStudy.GetRandomFunc();
            Console.WriteLine("Random Number = " + randomNumber.ToString());
            double sumValue = FuncStudy.CalculateFunc();
            Console.WriteLine("CalculateFunc = " + sumValue.ToString());
            Console.ReadLine();
                
        }
    }

}
