using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode
{
    class Day2
    {
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


        public Day2(string inputPath)
        {
            InputFilePath = inputPath;
        }

        public int GetAnswerPart1()
        {
            int horPos = 0, depthPos = 0;

            using (StreamReader sr = new StreamReader(InputFilePath))
            {
                while (!sr.EndOfStream)
                {
                    /*if (!int.TryParse(sr.ReadLine(), out curReading))
                    {
                        throw new ArgumentException("File path does not contain a parseable file.");
                    }*/

                    string[] curLine = sr.ReadLine().ToString().Split(' ');
                    int curValue;

                    if(!int.TryParse(curLine[1], out curValue))
                    {
                        throw new ArgumentException("Unrecognized value in input file, " + curLine[1]);
                    }

                    switch(curLine[0])
                    {
                        case "forward":
                            {
                                horPos += curValue;
                                break;
                            }
                        case "down":
                            {
                                depthPos += curValue;
                                break;
                            }
                        case "up":
                            {
                                depthPos -= curValue;
                                break;
                            }
                        default:
                            {
                                throw new ArgumentException("Unrecognized command in input file, " + curLine[0]);
                            }
                    }
                }
                sr.Close();
            }

            return (horPos * depthPos);
        }

        public int GetAnswerPart2()
        {
            int horPos = 0, depthPos = 0, aim =0;

            using (StreamReader sr = new StreamReader(InputFilePath))
            {
                while (!sr.EndOfStream)
                {
                    /*if (!int.TryParse(sr.ReadLine(), out curReading))
                    {
                        throw new ArgumentException("File path does not contain a parseable file.");
                    }*/

                    string[] curLine = sr.ReadLine().ToString().Split(' ');
                    int curValue;

                    if (!int.TryParse(curLine[1], out curValue))
                    {
                        throw new ArgumentException("Unrecognized value in input file, " + curLine[1]);
                    }

                    switch (curLine[0])
                    {
                        case "forward":
                            {
                                horPos += curValue;
                                depthPos += (aim * curValue);
                                break;
                            }
                        case "down":
                            {
                                //depthPos += curValue;
                                aim += curValue;
                                break;
                            }
                        case "up":
                            {
                                //depthPos -= curValue;
                                aim -= curValue;
                                break;
                            }
                        default:
                            {
                                throw new ArgumentException("Unrecognized command in input file, " + curLine[0]);
                            }
                    }
                }
                sr.Close();
            }

            return (horPos * depthPos);
        }

    }
}
