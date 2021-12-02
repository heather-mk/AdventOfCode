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
            Console.WriteLine("** Advent of Code **");
            Console.Write("Enter the day to execute: ");
            string dayInput = Console.ReadLine();
            Console.WriteLine();

            string root_path = System.IO.Path.GetDirectoryName(System.IO.Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location));

            switch (dayInput)
            {
                case "1":
                    {
                        
                        var d1 = new Day1(System.IO.Path.Combine(root_path, "input", "day1_input.txt"));
                        Console.WriteLine("--- Day 1: Sonar Sweep ---");
                        Console.Write("First answer: ");
                        Console.WriteLine(d1.GetAnswerPart1());
                        Console.Write("Second answer: ");
                        Console.WriteLine(d1.GetAnswerPart2());
                        break;
                    }
                case "2":
                    {
                        var d2 = new Day2(System.IO.Path.Combine(root_path, "input", "day2_input.txt"));
                        Console.WriteLine("--- Day 2: Dive! ---");
                        Console.Write("First answer: ");
                        Console.WriteLine(d2.GetAnswerPart1());
                        Console.Write("Second answer: ");
                        Console.WriteLine(d2.GetAnswerPart2());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Either day is invalid, or this day hasn't been done yet. Press enter to exit.");
                        break;
                    }
            }           
            Console.ReadKey();
        }
    }
}
