using System;

namespace EmployeewageUC1
{
    class EmployeewageCompute
    {
        /// <summary>
        /// Entry point of the applicaiton.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Constant
            int IS_PRESENT = 1;
            //Generating random input using predefined Random class
            Random random = new Random();
            int empInput = random.Next(0, 2);
            //if-else construct
            if (IS_PRESENT == empInput)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
