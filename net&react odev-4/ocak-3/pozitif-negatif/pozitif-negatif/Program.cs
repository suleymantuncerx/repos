using System;

namespace PozitifNegatif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            string input = Console.ReadLine();
            double number;

            if (double.TryParse(input, out number))
            {
                if (number > 0)
                {
                    Console.WriteLine("Girilen sayı pozitiftir.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Girilen sayı negatiftir.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı sıfırdır.");
                }
            }

        }
    }
}