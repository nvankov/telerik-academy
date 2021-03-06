﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.AddLineNumbers
{
    class AddLineNumbers
    {
        private const string FILENAME = "test.txt";

        public static void AddLineNumberToFIle(string filename)
        {
            string newFile = String.Format("{0}WithLines.txt", filename);

            using (StreamReader reader = new StreamReader(filename))
            {
                using (StreamWriter writer = new StreamWriter(newFile))
                {
                    string line = reader.ReadLine();
                    int lineNumber = 0;

                    while (line != null)
                    {
                        writer.WriteLine("Line {0}: {1}", lineNumber, line);
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                AddLineNumberToFIle(FILENAME);
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Error: {0}", fe.Message);
            }
            catch (UnauthorizedAccessException ue)
            {
                Console.WriteLine("Could not read or write to file. Permission is denied. {0}", ue.Message);
            }
        }
    }
}
