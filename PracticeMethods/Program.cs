using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMethods
{
    class Student
    {
        string firstName;
        string lastName;
        int age;

        public Student(string a, string b, int x)
        {
            firstName = a;
            lastName = b;
            age = x;
        }

        public string GetInfo()
        {
            return firstName + " " + lastName + " is " + age;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string first;
            string last;
            int num;
            Student st1 = new Student("Julian", "Harrell", 32);
            Student st2 = new Student("James", "Brown", 56);

            Console.WriteLine("Enter first name");
            first = Console.ReadLine();
            Console.WriteLine("Enter last name");
            last = Console.ReadLine();
            Console.WriteLine("Enter age using numbers");
            num = int.Parse(Console.ReadLine());
            Student st3 = new Student(first, last, num);

            Console.WriteLine(st1.GetInfo());
            Console.WriteLine(st2.GetInfo());
            Console.WriteLine(st3.GetInfo());
            Console.WriteLine("");
        }
    }
}
