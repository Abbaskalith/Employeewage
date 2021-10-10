using System;

namespace EmployeewageUC3
{
    class EmployeewageCompute
    {
        /// Contants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            //Local varibles
            int empHrs = 0;
            int empWage = 0;

            //Generating random input using predefined Random class
            Random random = new Random();
            int empInput = random.Next(0, 3);

            //if-else construct
            if (empInput == 1)
            {
                Console.WriteLine("Employee is present full time");
                empHrs = 8;
            }
            else if (empInput == 2)
            {
                Console.WriteLine("Employee is present part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            //Calculating daily employee wage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage:{0}", empWage);
            Console.ReadLine();
        }
    }
}
