using System;
namespace investment
{
    public class Investment
    {
        // Declare fields;
        public static double Principal;
        public static double Interest;
        public static double NumberOfYears;

         // Generate Constructor 
        public Investment(double principal, double interest, double numberOfYears)
        {
            Principal = principal;
            Interest = interest;
            NumberOfYears = numberOfYears;
        }
        public static double InvestmentReturns()
        {
            // Method that calculates returns on investments 
            
            double value = Principal * (1 + Interest) * NumberOfYears;
            Console.WriteLine($"The Value of your investment at the end of {NumberOfYears} years is {value}");

            return value;
        }
    }
}