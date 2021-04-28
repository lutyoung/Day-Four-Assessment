using System;

namespace Work
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Credit Card Number: ");

            long creditCard = Convert.ToInt64(Console.ReadLine());//Recieving credit number from user

            if(ISValid(creditCard))//  Using "if and else" statement  To Check if the Card nnumber is valid or nit 
            {
                Console.WriteLine("Your Credit Card number " + creditCard + " is Valid");
            }else
            {
                Console.WriteLine("Your Credit Card number " + creditCard + " is Not Valid");
            }
            
        }

        //Return the number if the ditgit is single, else  retrun the sum of the two didgit if is double
        public static int GetDigit(int number)
        {
            if(number < 9)
            {
                return number;
            }
            return number/10 + number % 10;
        }

        //Return the size of Number of digit
        public static int Size(long n)
        {
            String number = n + "";

            return number.Length;
        }

        //Write method that will get the result from step 2
        //It will Add All single digit number from step 1
        public static int DoubleSumOfEvenPlaces(long number)
        {
            int sum = 0;

            String num = number + "";
            for(int i = Size(number) - 2; i >= 0; i-=2)
            {
                sum += GetDigit(int.Parse(num[i] +"") * 2);
            }

            return sum;

        }

        //This method will add all odd places from right to left in the number
        public static int SumOddPlaces(long number)
        {
            int sum = 0;
            String num = number + "";
            for(int i = Size(number) - 2; i >= 0; i-=2)
            {
                sum += int.Parse(num[i] +"");
            }
            return sum;
        }
        //Return the first c number of digits from number
        //If the Size is less the number is less than c, return the number
        public static long Prefix(long number, int c)
        {
            if (Size(number) > c)
            {
                String digit = number + "";
                return long.Parse(digit.Substring(0, c));
            }
            return number;
        }

        //Retrun True if the digit n is a prefix for number
        public static bool IsMatched(long number, int n)
        {
            return Prefix(number, Size(n)) == n;
        }

        //This method will Return true if the card number is valid else return false 
        public static bool ISValid(long number)
        {
            bool cardNumber  = (Size(number)>=13 && Size(number) <= 16) && (IsMatched(number, 4) || IsMatched(number, 5) || IsMatched(number, 37) || IsMatched(number, 6)) && ((DoubleSumOfEvenPlaces(number) + SumOddPlaces(number)) % 10 == 0);

            return cardNumber;
        }
    }
}
