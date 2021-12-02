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
        private string _inputFilePath;
        private const string _question = "How many measurements are larger than the previous measurment?";
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
        public string Question
        {
            get { return _question; }
        }

        public Day1(string inputPath)
        {
            InputFilePath = inputPath;
        }

        public int GetAnswer()
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
    }
}
