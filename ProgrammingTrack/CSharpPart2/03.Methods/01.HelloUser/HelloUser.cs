using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloUser
{
    public class HelloUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hello("Pesho")); 
        }

        public static string Hello(string userName)
        {
            return "Hello " + userName + "!";
        }
    }
}
