using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using GeneralLibrary;

namespace GeneralConsoleApp
{
    public class Program
    {
        // Delegate declaration.
        public delegate void SimpleDelegate();

        static void Main(string[] args)
        {
            // Test Func delegate.
            /*
            int randomNumber = FuncStudy.GetRandomFunc();
            Console.WriteLine("Random Number = " + randomNumber.ToString());
            double sumValue = FuncStudy.CalculateFunc();
            Console.WriteLine("CalculateFunc = " + sumValue.ToString());
            Console.ReadLine();
            */

            // Test Timer.
            /*
            System.Timers.Timer aTimer = new System.Timers.Timer(3000);            

            Console.WriteLine("Press the Enter key to exit the application. \n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            aTimer.Elapsed += OnTimedEvent;

            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
            Console.WriteLine("Terminating the application.");
            */

            // Test Delegate.
            /*
            ProcessClass processClass = new ProcessClass();
            processClass.Process();

            // Instantiation.
            SimpleDelegate simpleDelegate = new SimpleDelegate(MyMethod);

            // Invocation.
            simpleDelegate();
            */
                                   

            Console.ReadKey();

            


        }

        public static void MyMethod()
        {
            Console.WriteLine("Called by a delegate");
        }

        public class ProcessClass
        {
            public void Process()
            {
                Console.WriteLine("Process() Start");
                Console.WriteLine("Process() Finish");
            }
        }
               
        /* Test Timer.
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                                e.SignalTime);
        }
        */
    }
}

