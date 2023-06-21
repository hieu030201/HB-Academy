using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information");
            Console.WriteLine("----------------***----------------");
            Console.Write("Enter student name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter Gender ( male / female): ");
            string gender = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = System.Int32.Parse(Console.ReadLine());

            Console.Write("Enter birthday (dd/mm/yy): ");
            string birthday = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter father's name: ");
            string fatherName = Console.ReadLine();

            Console.Write("Enter mother's name: ");
            string motherName = Console.ReadLine();

            Console.WriteLine("***Student Infomation***");
            //Xuống dòng trong c#
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Student name: {0}", fullName);
            Console.WriteLine("Student gender: {0}", gender);
            Console.WriteLine("Student age: {0}", age);
            Console.WriteLine("Student birthday: {0}", birthday);
            Console.WriteLine("Student address: {0}", address);
            Console.WriteLine("Student's father name: {0}", fatherName);
            Console.WriteLine("Student's mother name: {0}", motherName);

            Console.ReadKey();

        }
    }
}
