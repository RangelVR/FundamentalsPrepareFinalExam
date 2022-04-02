using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int countOfNumbersOfDivisible = 5;
            // 2, 3, 6, 7, 10
            int biggestDivider = 0;

            for (int i = 0; i < countOfNumbersOfDivisible; i++)
            {
                biggestDivider = 0;

                if (num % 2 == 0)
                {
                    biggestDivider = 2;
                }
                if (num % 3 == 0)
                {
                    biggestDivider = 3;
                }
                if (num % 6 == 0)
                {
                    biggestDivider = 6;
                }
                if (num % 7 == 0)
                {
                    biggestDivider = 7;
                }
                if (num % 10 == 0)
                {
                    biggestDivider = 10;
                }

            }

            if (biggestDivider > 0)
            {
                Console.WriteLine($"The number is divisible by {biggestDivider}");
            }
            else
            {
                Console.WriteLine("Not divisible");   
            }
            

        }
    }
}
