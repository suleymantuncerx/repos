// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine("Birinci sayıyı giriniz:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /):");
char islem = Console.ReadKey().KeyChar;
Console.WriteLine();

double sonuc;

switch (islem)
{
    case '+':
        sonuc = sayi1 + sayi2;
        Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        break;
    case '-':
        sonuc = sayi1 - sayi2;
        Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        break;
    case '*':
        sonuc = sayi1 * sayi2;
        Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
        break;
    case '/':
        if (sayi2 != 0)
        {
            sonuc = sayi1 / sayi2;
            Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
        }
        else
        {
            Console.WriteLine("Hata: Bir sayıyı 0'a bölemezsiniz.");
        }
        break;
    default:
        Console.WriteLine("Geçersiz işlem seçimi.");
        break;
}

