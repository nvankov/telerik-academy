using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _03.GetFullPathAndReadFile
{
    class GetFullPathAndReadFile
    {
        static void Main(string[] args)
        {
            string pathToFile = @"C:\test.txt";

            try
            {
                Console.WriteLine(File.ReadAllText(pathToFile));
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is empty");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The path contains one or more invalid characters");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid or it is on an unmapped drive.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("path specified a file that is read-only.");
                Console.WriteLine("-or-");
                Console.WriteLine("This operation is not supported on the current platform.");
                Console.WriteLine("-or-");
                Console.WriteLine("path specified a directory.");
                Console.WriteLine("-or-");
                Console.WriteLine("The caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The path is in an invalid format.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
        }
    }
}
