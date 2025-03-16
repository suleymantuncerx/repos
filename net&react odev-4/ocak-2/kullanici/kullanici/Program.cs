using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        string input1 = Console.ReadLine();
        Console.Write("İkinci sayıyı girin: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine("Toplam: " + sum);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen sayıları doğru formatta girin.");
        }
    }
}