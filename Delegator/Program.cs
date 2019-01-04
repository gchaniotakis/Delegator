using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegator
{
    delegate double Calculator(double a, double b);


    class Program
    {
        static Dictionary<string, Calculator> operations;

        static void Main(string[] args)
        {
            operations = new Dictionary<string, Calculator>();

            operations.Add("+", Add);
            operations.Add("-", Subtract);
            operations.Add("*", Multiply);
            

            double a = 5.0;
            double b = 12.33;

            //Calculator add = Add;

            //var result = add(a, b);
            //var r2 = add.Invoke(a, b);

            var op = "*";
            var result = operations[op](a, b);
            Console.WriteLine(result);
            Console.Read();
        }

        static double Add (double x, double y)
        {
            return x + y;
        }

        static double Subtract (double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x , double y)
        {
            return x * y;
        }
    }
}
