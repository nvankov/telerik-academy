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
        private const string FIRSTFILE = "first.txt";
        private const string SECONDFILE = "second.txt";
        private const string CONCATENADED = "concat.txt";

        public static void ConcatenateFiles(string firstFile, string secondFile, string fileToWrite)
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
            
            //Прочитаме първият файл и записваме съдържанието му в друг
            using (StreamReader reader = new StreamReader(firstFile, encoding))
            {
                using (StreamWriter writer = new StreamWriter(fileToWrite, false, encoding))
                {
                    writer.Write(reader.ReadToEnd());
                }
            }

            //Прочитаме съдържанието на другият файл и го добавяме към новият файл
            using (StreamReader reader = new StreamReader(secondFile, encoding))
            {
                using (StreamWriter writer = new StreamWriter(fileToWrite, true, encoding))
                {
                    writer.Write(reader.ReadToEnd());
                }
            }
        }

        public static void PrintFileToConsole(string filename)
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            using (StreamReader reader = new StreamReader(filename, encoding))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ConcatenateFiles(FIRSTFILE, SECONDFILE, CONCATENADED);
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Error: {0}", fe.Message);
            }
            catch (UnauthorizedAccessException ue)
            {
                Console.WriteLine("Could not read or write to file. Permission is denied. {0}", ue.Message);
            }

            Console.WriteLine("Operation successful, reading newly created file: ");

            PrintFileToConsole(CONCATENADED);
        }
    }
}
