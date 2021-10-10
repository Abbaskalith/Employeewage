using System;

namespace EmployeewageUC3
{
    class EmployeewageCompute
    {
        /// Contants
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            //Constant
            int PRESENT = 1;
            //Local varibles
            int empHrs = 0;
            int empWage = 0;
            //Generating random input using predefined Random class
            Random random = new Random();
            int empInput = random.Next(0, 2);
            //if-else construct
            if (PRESENT == empInput)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage:{0}", empWage);
            Console.ReadLine();
        }
    }
}
