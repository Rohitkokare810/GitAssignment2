using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string EMPNAME;
            char gender;
            double salary;
            DateTime doj;
            Console.WriteLine("Enter ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            EMPNAME = Console.ReadLine();
            Console.WriteLine("Enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date Of Joining");
            doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nID\tEMPLOYEE NAME\tEMPLOYEE GENDER\tEMPLOYEE SALARY\tDOJ");
            Console.WriteLine(ID + "\t" + EMPNAME + "\t" + gender + "\t" + salary + "\t" + doj);

            double tax=0;
            if(salary>90000)
            {
                tax = salary * 0.3;
            }
            else
            {
                tax = salary * 0.15;
            }
            Console.WriteLine("\nYou have to pay: " + tax);
            Console.ReadKey();




        }
    }
}
