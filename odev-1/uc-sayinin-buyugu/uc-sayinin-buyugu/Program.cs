// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// SAYI GİRME İŞLEMİ
Console.Write("Birinci sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

// ÇIKTI İŞLEMİ
if (sayi1 >= sayi2 && sayi1 >= sayi3)
{
    Console.WriteLine("Büyük sayı: " + sayi1);
}
else if (sayi2 >= sayi1 && sayi2 >= sayi3)
{
    Console.WriteLine("Büyük sayı: " + sayi2);
}
else if(sayi3 >=sayi2 && sayi3 >=sayi1)
{
    Console.WriteLine("Büyük sayı: " + sayi3 );
}
