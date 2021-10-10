using System;

namespace EmployeewageUC5
{
    class EmployeewageCompute
    {
        /// Contants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NO_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //Local varibles
            int empHrs = 0;
            int totalEmpwage = 0;
            int day;
            int totalEmphrs = 0;

            //Generating random input using predefined Random class
            Random random = new Random();
            //for loop for calculating employee working hrs for a month
            for (day=1; day <= NO_OF_WORKING_DAYS; day++)
            { 
                //using Next() method to generating random input 
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
                //Formula for calulating total employee working hrs for a month
                totalEmphrs += empHrs;
            }
            //Calculating total employee wage for a month
            totalEmpwage = EMP_RATE_PER_HR * totalEmphrs;
            Console.WriteLine("Employee wage:{0}", totalEmpwage);
            Console.ReadLine();
        }
    }
}
