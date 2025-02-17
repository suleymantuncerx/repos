// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//SAYI GİRME İŞLEMİ
Console.Write("Lütfen Geçerli Bir Sayı Giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

//SIFIRDAN BÜYÜK YADA EŞİT
if (sayi >= 0)
{
    Console.WriteLine("Girdiğiniz Sayı Pozitif bir sayıdır");

}
//SIFIRDAN KÜÇÜK YADA EŞİT
else if (sayi <=0)
{
    Console.WriteLine("Girdiğiniz Sayı Negatif Bir Sayıdır");
    
}

//SIFIRA EŞİT
else if (sayi == 0)
{
    Console.WriteLine("Girdiğiniz Sayı Negatif Bir Sayıdır");
}
