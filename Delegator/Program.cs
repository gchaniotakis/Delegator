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

            //Calculator calculator = Add;
            //var result = calculator(a, b);
            //var r2 = calculator.Invoke(a, b);
            //calculator = Subtract;
            //result = calculator (a,b);

            var op = "*";
            var result = operations[op](a, b);
            Console.WriteLine(result);
            Console.Read();


            Calculator multicast = Add;
            multicast += Subtract;
            multicast += Multiply;

            var final = multicast(5, 5);
            Console.WriteLine(multicast);
            Console.ReadKey();



            Callbacks.ProcessFile("test.txt", Callbacks.PrintLine);
            Callbacks.ProcessFile("test.txt", Callbacks.PrintCharCount);
            Callbacks.ProcessFile("test.txt", Console.WriteLine);
            Console.ReadKey();


            var blog = new Blog();

            var reader1 = new Reader(blog);
            var reader2 = new Reader(blog);

            blog.Post ("test", "test content");
            
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
