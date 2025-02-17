// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// GİRİLECEK SAYI BELİRTME

Console.WriteLine("Birinci sayıyı giriniz:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /):");
char islem = Console.ReadKey().KeyChar;
Console.WriteLine();

double sonuc;


//İŞLEM SEÇİMİ

switch (islem)
{
    case '+':
        //SAYI1 SAYI2 TOPLAMA
        sonuc = sayi1 + sayi2;

        //SAYI1 SAYI2 SONUC
        Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        break;
    case '-':
        //SAYI1 SAYI2 ÇIKARTMA
        sonuc = sayi1 - sayi2;

        //SAYI1 SAYI2 SONUC
        Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        break;
    case '*':
        //SAYI1 SAYI2 CARPMA
        sonuc = sayi1 * sayi2;

        //SAYI1 SAYI2 SONUC
        Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
        break;
    case '/':
        //SIFIRA EŞİT OLMAYACAK
        if (sayi2 != 0)
        {
            sonuc = sayi1 / sayi2;

            //SAYI1 SAYI2 SONUC
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

