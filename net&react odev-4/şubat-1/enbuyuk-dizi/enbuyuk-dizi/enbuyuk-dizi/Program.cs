using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 1, 3, 5,15,25,2,4 };
        int enBuyukSayi = EnBuyukSayiyiBul(sayilar);
        Console.WriteLine("Dizideki en büyük sayı: " + enBuyukSayi);
    }

    static int EnBuyukSayiyiBul(int[] dizi)
    {
    

        int max = dizi[0];
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > max)
            {
                max = dizi[i];
            }
        }
        return max;
    }
}