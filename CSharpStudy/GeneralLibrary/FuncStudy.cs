using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary
{
    public static class FuncStudy
    {
        // Get a random value, using Func.
        public static int GetRandomFunc()
        {
            Func<int> func = GetRandomMethod;
            return func();
        }

        // Calculate the sum between two values, using Func.
        public static double CalculateFunc()
        {
            Func<double, double, double> func = Calculate;
            return func(10, 20);
        }

        // Calculate the sum between two values;
        private static double Calculate(double a, double b)
        {
            return a + b;
        }

        // Get a random int value;
        private static int GetRandomMethod()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
