using System;
//Зад.37-3)
namespace SolvingAMathProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for q:");
            double q = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for p:");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for r:");
            double r = double.Parse(Console.ReadLine());
            bool a;
            bool b;
            double s = q / (p + r) - (3 * q);
            double t = 5 * p;
            if (s!=t)
            {
                a = true;
            }
            else
            {
                a = false;
            }
            if (p>=r)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            Console.WriteLine(a && b);
            Console.ReadKey(true);
        }
    }
}
