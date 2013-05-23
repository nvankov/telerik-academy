using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.PrintOddLinesOfText
{
    class PrintOddLinesOfText
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt";
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                int lineNumber = 0;
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    line = streamReader.ReadLine();
                    lineNumber++;

                    if (lineNumber % 2 == 0)
                    {
                        continue;
                    }

                    Console.WriteLine("Line: {0}, content: {1}", lineNumber, line);
                   
                    
                }
            }
        }
    }
}
