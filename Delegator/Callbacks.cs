using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegator    
{
    public delegate void ProcessString(string input);

    class Callbacks
    {
        public static void ProcessFile (string filename, ProcessString processor)
        {
            var content = File.ReadAllLines(filename);
            var line = content[0];

            processor(line);

        }

        public static void PrintCharCount (string input)
        {
            Console.WriteLine($"The input contains {input.Length} characters");
        }

        public static void PrintLine (string input)
        {
            Console.WriteLine(input);
        }
    }
}
