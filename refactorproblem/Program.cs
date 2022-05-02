// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace Outputter;
class program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 60;
    public const int NUM_OF_WORKING_DAYS = 20;
    public const int MAX_HRS_IN_MONTH = 60;
    public static int refactorproblem(int RefactorCodeEmpWage)
    {

        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
            return totalEmpWage;
        }
        return 0;
    }

    //static void RefactorCodeEmpWage(string[] args)
    //{
    //RefactorCodeEmpWage();
    //throw new NotImplementedException();
    //}

    public static void main(string[] args)
    {
        //throw new NotImplementedException();
        int v = refactorproblem();
    }

    private static int refactorproblem()
    {
        throw new NotImplementedException();
    }
}
