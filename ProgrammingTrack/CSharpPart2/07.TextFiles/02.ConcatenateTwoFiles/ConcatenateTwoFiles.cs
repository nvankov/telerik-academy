using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatenateTwoFiles
{
    class ConcatenateTwoFiles
    {
        static void Main(string[] args)
        {
            string firstFileName = "firstFile.txt";
            string secondFileName = "secondFile.txt";
            string concatenatedFiles = "concatenatedFiles.txt";
            string firstFileContent;
            string secondFileContent;

            try
            {
                StreamReader reader = new StreamReader(firstFileName);
                StreamWriter writer = new StreamWriter(concatenatedFiles);

                try
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
                finally
                {
                    writer.Close();
                    reader.Close();
                }

                StreamReader secondReader = new StreamReader(secondFileName);
                StreamWriter secondWriter = new StreamWriter(concatenatedFiles, true);

                try
                {
                    string line = secondReader.ReadLine();
                    while (line != null)
                    {
                        secondWriter.WriteLine(line);
                        line = secondReader.ReadLine();
                    }
                }
                finally
                {
                    secondWriter.Close();
                    secondReader.Close();
                }


            }

            catch (Exception e)
            {
                Console.WriteLine("An error occured: {0}", e.Message);
            }
            Console.WriteLine("Operation completed.");

        }
    }
}
