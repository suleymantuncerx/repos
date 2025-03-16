using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
}
