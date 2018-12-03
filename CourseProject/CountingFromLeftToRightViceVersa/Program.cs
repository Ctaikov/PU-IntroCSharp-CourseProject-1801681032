using System;
/*Зад.13 - Да се напише програма, която въвежда положително седемцифрено число и извежда неговата k-та цифра (1<=k<=7), като цифрите се броят:
 а) в посока отляво-надясно. б) в посока отдясно-наляво.*/
namespace CountingFromLeftToRightViceVersa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a seven digit number bigger than 0:");
            int[] number = new int[7];
            int k;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the number you want to take from left to right:");
            do
            {
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k > 7);
            for (int i = 0; i < number.Length; i++)
            {
                if (k == i)
                {
                    Console.WriteLine($"Your digit from left to right is {number[i - 1]}");
                }
            }
            int index = number.Length;
            int[] backwards = new int[index];
            for (int i = 0; i < number.Length; i++)
            {
                backwards[index - i - 1] = number[i];
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (k == i)
                {
                    Console.WriteLine($"Your digit from right to left is {backwards[i - 1]}.");
                }
            }
        }
    }
}
