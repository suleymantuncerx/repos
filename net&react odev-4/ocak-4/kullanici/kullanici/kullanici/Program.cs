using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı girin:");
        int number = int.Parse(Console.ReadLine());
        int sum = CalculateSum(number);
        Console.WriteLine($"{number} sayısına kadar olan sayıların toplamı: {sum}");
    }

    static int CalculateSum(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
        return sum;
    }
}