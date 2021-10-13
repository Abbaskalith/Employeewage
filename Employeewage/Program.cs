using System;

namespace EmployeewageUC7
{
    class EmployeewageCompute
    {
        /// Contants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NO_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;

        //GetEmployeeHrs class method to generate empHrs 
        public static int GetEmployeeHrs(int empInput)
        {
            int empHrs = 0;
            //switch construct
            switch (empInput)
            {
                case IS_FULL_TIME:
                    return empHrs = 8;
                    
                case IS_PART_TIME:
                   return empHrs = 4;
                   
                default:
                    return empHrs = 0;
                    
            }
        }
        public static void Main(string[] args)
        {
            //Local varibles
            int empHrs = 0;
            int empWage = 0;
            int totalEmpwage = 0;
            int day = 1;
            int totalEmphrs = 0;

            //Generating random input using predefined Random class
            Random random = new Random();
            //for loop for calculating employee working hrs for a month
            while (day <= MAX_WORKING_DAYS && totalEmphrs <= MAX_WORKING_HRS)
            { 
                //using Next() method to generating random input 
                int empInput = random.Next(0, 3);
                //Generating emphrs by using GetEmployeehrs Method
                empHrs =GetEmployeeHrs(empInput);
                //Formula for calulating total employee working hrs for a month
                totalEmphrs += empHrs;
                day++;
            }
            //Calculating total employee wage for a month
            totalEmpwage = EMP_RATE_PER_HR * totalEmphrs;
            Console.WriteLine("Employee wage:{0}", totalEmpwage);
            Console.ReadLine();
        }
    }
}
