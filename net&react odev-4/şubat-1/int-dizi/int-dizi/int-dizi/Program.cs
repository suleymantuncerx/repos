using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[5];

        Console.WriteLine("Lütfen 5 sayı girin:");

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"sayı {i + 1}: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Girilen  sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}