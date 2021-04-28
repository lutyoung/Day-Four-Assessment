using System;

namespace investment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your principal: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your interest: ");
            double interest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            double numberOfYears = Convert.ToDouble(Console.ReadLine());

            Investment investment = new Investment(principal, interest, numberOfYears); // Initialize Investment class with its constructors

            Investment.InvestmentReturns();  // call investmentReturns method from investment class

            if (numberOfYears <= 3)
            {

                interest = 50;
            }
        }
    }
}
