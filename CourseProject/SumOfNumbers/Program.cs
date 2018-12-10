using System;
//Зад.213в).
namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int max = 51;
                int sum = 0;
                int maxTwo = 18;
                int sumTwo = 0;
                for (int i = 0; i <= 51; i++)
                {
                    for (int j = 2; j <= maxTwo; j++)
                    {
                        sumTwo = j;
                    }
                    for (int k = 3; k <= max; k += 3)
                    {
                        sum = k;
                    }
                }
                double sumAll = 1 / Math.Pow(sum, sumTwo);
                Console.WriteLine("((1/3)*2)+((1/6)*3)+((1/9)*4)+...+((1/48)*17)+((1/51)*18)=" + sumAll);
            }
        }
    }
}
