using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyManagerAndInfo
{
    public struct Manager 
    {
        public Manager(string firstName, string lastName, ushort age, string phoneNumber) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
        }

        public string FirstName;
        public string LastName;
        public ushort Age;
        public string PhoneNumber; //using a string because the user might type in a + sign (+359 878 888 888)
    }

    public struct Company
    {
        public Company(string companyName, string address, string phoneNumber, string faxNumber, string website, Manager manager)
        {
            this.Name = companyName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.FaxNumber = faxNumber;
            this.Website = website;
            this.Manager = manager;
        }

        public string Name;
        public string Address;
        public string PhoneNumber;
        public string FaxNumber;
        public string Website;
        public Manager Manager;
    }

    class CompanyManagerAndInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill in the information: ");
            Console.Write("Company Name: ");
            string n = Console.ReadLine();
            Console.Write("Company addres: ");
            string a = Console.ReadLine();
            Console.Write("Company phone: ");
            string p = Console.ReadLine();
            Console.Write("Company fax: ");
            string f = Console.ReadLine();
            Console.Write("Company website: ");
            string w = Console.ReadLine();
            Console.Write("Manager first name: ");
            string fn = Console.ReadLine();
            Console.Write("Manager last name: ");
            string ln = Console.ReadLine();
            Console.Write("Manager age: ");
            ushort age = ushort.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string mp = Console.ReadLine();
            Console.WriteLine();

            Manager manager = new Manager(fn, ln, age, mp);
            Company company = new Company(n, a, p, f, w, manager);

            Console.WriteLine("Company information: ");
            Console.WriteLine("Name: {0}\nAddres: {1}\nPhone: {2}\nFax: {3}\nWebsite: {4}", 
                company.Name, company.Address, company.PhoneNumber, company.FaxNumber, company.Website);
            Console.WriteLine("Manager information: ");
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nManager Phone: {3}",
                company.Manager.FirstName, company.Manager.LastName, company.Manager.Age, company.Manager.PhoneNumber);
        }
    }
}
