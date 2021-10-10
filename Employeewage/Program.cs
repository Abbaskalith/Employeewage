using System;

namespace EmployeewageUC4
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

            //switch construct
            switch (empInput)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            //Calculating employee wage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage:{0}", empWage);
            Console.ReadLine();
        }
    }
}
