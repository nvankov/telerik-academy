﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintFileOddLines
{
    class PrintFileOddLines
    {
        const string FILENAME = "text.txt";

        static void PrintOddLines(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);

            using (streamReader)
            {
                string line = streamReader.ReadLine();
                int lineNumber = 1;

                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        lineNumber++;
                        line = streamReader.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    lineNumber++;
                    line = streamReader.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                PrintOddLines(FILENAME);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Couldn't find a file with the name {0}", FILENAME);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Could not read file. Permission is denied.");
            }
            


        }
    }
}
