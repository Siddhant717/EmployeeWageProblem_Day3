using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.CheckEmployeeAttendance();
        }

        public static void CheckEmployeeAttendance()
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 0)
            {
                Console.WriteLine("Employee is absent");
                
            }
            else
            {
                Console.WriteLine("Employee is present");
                
            }
        }
    }
}
