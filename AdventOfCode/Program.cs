using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // something for each day
            string d1_path = System.IO.Path.GetDirectoryName(System.IO.Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location));
            var d1 = new Day1(System.IO.Path.Combine(d1_path, "input","day1_input.txt"));
            Console.Write(d1.Question + " ");
            Console.Write(d1.GetAnswer());

            Console.ReadKey();
        }
    }
}
