using System;

namespace ConvertingToBinOctHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2032;
            string bin = Convert.ToString(2032, 2);
            string oct = Convert.ToString(2032, 8);
            string hex = Convert.ToString(2032, 16);
            Console.WriteLine($"The number {number} in Binary is {bin}.");
            Console.WriteLine($"The number {number} in Octal is {oct}.");
            Console.WriteLine($"The number {number} in Hexadecimal is {hex}.");
        }
    }
}
