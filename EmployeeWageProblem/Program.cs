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

            int FullDayHr = 8;
            int WagePerHr = 20;
            int totalWage = 0;
            int PartTimeHr = 4;
            Random random = new Random();
            int number = random.Next(0, 3);
            if (number == 0)
            {
                Console.WriteLine("Employee is absent");
                

            }
            else if(number==1)
            {
                Console.WriteLine("Employee is present");
                totalWage = FullDayHr * WagePerHr;
              
            }
            else
            {
                Console.WriteLine("Employee is present and part time employee");
                totalWage = PartTimeHr * WagePerHr;
               
            }
            Console.WriteLine("Employee's total wage  is " + totalWage);
        }
    }
}
