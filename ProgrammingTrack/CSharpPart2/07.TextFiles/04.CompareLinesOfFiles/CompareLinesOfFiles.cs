﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.CompareLinesOfFiles
{
    public struct Lines
    {
        public Lines(int same, int different)
        {
            this.same = same;
            this.different = different;
        }

        public int same;
        public int different;
    }

    class CompareLinesOfFiles
    {
        private const string FIRSTFILE = "first.txt";
        private const string SECONDFILE = "second.txt";

        public static Lines CompareLines(string firstFile, string secondFile)
        {
            Lines lines = new Lines(0, 0);
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            using (StreamReader firstReader = new StreamReader(firstFile, encoding))
            {
                using (StreamReader secondReader = new StreamReader(secondFile, encoding))
                {
                    string firstFileLine = firstReader.ReadLine();
                    string secongFileLine = secondReader.ReadLine();

                    while (firstFileLine != null || secongFileLine != null)
                    {
                        if (firstFileLine == secongFileLine)
                        {
                            lines.same++;
                            firstFileLine = firstReader.ReadLine();
                            secongFileLine = secondReader.ReadLine();
                        }
                        else
                        {
                            lines.different++;
                            firstFileLine = firstReader.ReadLine();
                            secongFileLine = secondReader.ReadLine();
                        }
                    }
                }
            }

            return lines;
        }

        static void Main(string[] args)
        {
            Lines lines = new Lines(0, 0);

            try
            {
                lines = CompareLines(FIRSTFILE, SECONDFILE);
                Console.WriteLine("Number of identical lines: {0}", lines.same);
                Console.WriteLine("Number of different lines: {0}", lines.different);
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
