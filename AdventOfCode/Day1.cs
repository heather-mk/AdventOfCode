using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode
{
    class Day1
    {
        // https://adventofcode.com/2021/day/1#part2
        private string _inputFilePath;
     
        public string InputFilePath
        {
            get
            {
                return _inputFilePath;
            }
            set
            {
                if (!System.IO.File.Exists(value))
                {
                    throw new ArgumentException("Input file does not exist.");
                }
                _inputFilePath = value;
            }
        }
   

        public Day1(string inputPath)
        {
            InputFilePath = inputPath;
        }

        public int GetAnswerPart1()
        {
            int prevReading = 0, curReading = 0, numIncreases = 0;

            using (StreamReader sr = new StreamReader(InputFilePath))
            {
                while (!sr.EndOfStream)
                {
                    if (!int.TryParse(sr.ReadLine(), out curReading))
                    {
                        throw new ArgumentException("File path does not contain a parseable file.");
                    }
                    if (prevReading != 0 && curReading > prevReading)
                    {
                        numIncreases++;
                    }
                    prevReading = curReading;
                }
                sr.Close();
            }
            return numIncreases;
        }

        public int GetAnswerPart2()
        {
            List<int> resultList = new List<int>();
            List<int> window = new List<int>();
            int curReading = 0, prevSum = 0, numIncreases = 0;

            using (StreamReader sr = new StreamReader(InputFilePath))
            {
                while (!sr.EndOfStream)
                {
                    if (!int.TryParse(sr.ReadLine(), out curReading))
                    {
                        throw new ArgumentException("File path does not contain a parseable file.");
                    }

                    window.Add(curReading);
                    if (window.Count >= 3)
                    {
                        // sum the readings and add to results
                        if (window.Count > 3)
                        {
                            window.RemoveAt(0);
                        }
                        resultList.Add(window.Sum());
                    }
                }
                sr.Close();
            }

            // iterate through results to find increases and decreases
            foreach(int curSum in resultList)
            {
                if(prevSum != 0 && curSum > prevSum)
                {
                    numIncreases++;
                }
                prevSum = curSum;
            }

            return numIncreases;
        }
    }
}
