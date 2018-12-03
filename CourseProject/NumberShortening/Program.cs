using System;
/*Зад. 159 - Напишете метод, който съкращава смесена дроб.*/
namespace NumberShortening
{
    class Program
    {
        static void Main(string[] args)
        {
            long num, denom, p, q;
            char symbol;
            do
            {
                Console.WriteLine("Enter a numinator:");
                num = int.Parse(Console.ReadLine());
            }
            while (num == 0);
            do
            {
                Console.WriteLine("Enter a denuminator");
                denom = int.Parse(Console.ReadLine());

            } while (denom == 0);
            if (num * denom >= 0)
            {
                symbol = ' ';
            }
            else
            {
                symbol = '-';
            }
            num = Math.Abs(num);
            denom = Math.Abs(denom);
            Reduce(num, denom, out p, out q);
            Console.WriteLine("The entered fraction is " + symbol + num + "/" + denom);
            Console.WriteLine("It's shortened by " + symbol + p + "/" + q);
            Console.ReadKey();
        }
        static long Nod(long a, long b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        static void Reduce(long a, long b, out long q, out long p)
        {
            long divisor = Nod(a, b);
            p = a / divisor;
            q = b / divisor;
        }
    }
}
