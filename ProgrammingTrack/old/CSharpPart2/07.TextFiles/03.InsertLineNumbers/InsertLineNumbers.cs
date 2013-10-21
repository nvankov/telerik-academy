using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("test.txt");
                StreamWriter writer = new StreamWriter("testWithLines.txt");

                string line = reader.ReadLine();
                int lineCount = 1;

                while (line != null)
                {
                    writer.WriteLine("Line " + lineCount + ": " + line);
                    lineCount++;
                    line = reader.ReadLine();
                }

                reader.Close();
                writer.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Could not locate the source file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You dont have permission to write in this directory.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
