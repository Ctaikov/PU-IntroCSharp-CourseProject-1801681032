using System;
//Зад.372а)к).
namespace SortingAndComparingCityNames
{
    class Program
    {
        static string[] cities;

        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Enter the number of cities: ");
                count = int.Parse(Console.ReadLine());
            } while (count < 1 || count > 50);
            cities = new string[count];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("Enter {0} city's name:", i + 1);
                cities[i] = Console.ReadLine();
            }
            Sort(); Output();
        }
        static void Sort()
        {
            for (int i = 1; i < cities.Length; i++)
            {
                for (int j = cities.Length - 1; j >= i; j--)
                {
                    if (String.Compare(cities[j - 1], cities[j]) > 0 || String.Compare(cities[j - 1], cities[j]) == 0)
                    {
                        string placeholder = cities[j];
                        cities[j] = cities[j - 1];
                        cities[j - 1] = placeholder;
                    }
                }
            }
        }
        static void Output()
        {
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
        }
    }
}
