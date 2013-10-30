using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentLINQQueries
{
    class StudentLINQQueries
    {
        static void Main(string[] args)
        {
            Student[] studentArray = 
            {
                new Student("Petar", "Petrov", 23),
                new Student("Ivan", "Ivanov", 17),
                new Student("Angel", "Georgiev", 22),
                new Student("Georgi", "Atanasov", 24),
                new Student("Georgi", "Atanasov", 33)
            };

            var FirstNameFirst =
                from student in studentArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var item in FirstNameFirst)
            {
                Console.WriteLine(item);
            }

            var averageAge =
                from student in studentArray
                where student.Age >= 18 && student.Age < 24
                select student;

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in averageAge)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            var sortedStudents = studentArray.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Using LINQ
            var LINQSortedStudents =
                from student in studentArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var item in LINQSortedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
