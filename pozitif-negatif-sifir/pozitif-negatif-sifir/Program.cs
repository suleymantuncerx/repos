// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("Lütfen Geçerli Bir Sayı Giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi >= 0)
{
    Console.WriteLine("Girdiğiniz Sayı Pozitif bir sayıdır");

}
else if (sayi <=0)
{
    Console.WriteLine("Girdiğiniz Sayı Negatif Bir Sayıdır");
    
}
else if (sayi == 0)
{
    Console.WriteLine("Girdiğiniz Sayı Negatif Bir Sayıdır");
}
