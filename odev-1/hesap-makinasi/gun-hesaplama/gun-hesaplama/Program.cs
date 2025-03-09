// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// SAYI İŞLEME
Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı giriniz:");
int gunNumarasi = Convert.ToInt32(Console.ReadLine());

string gunIsmi;

// GÜN ÇIKTISI
switch (gunNumarasi)
{
    case 1:
        gunIsmi = "Pazartesi";
        break;
    case 2:
        gunIsmi = "Salı";
        break;
    case 3:
        gunIsmi = "Çarşamba";
        break;
    case 4:
        gunIsmi = "Perşembe";
        break;
    case 5:
        gunIsmi = "Cuma";
        break;
    case 6:
        gunIsmi = "Cumartesi";
        break;
    case 7:
        gunIsmi = "Pazar";
        break;
    default:
        gunIsmi = "Geçersiz gün numarası";
        break;
}
Console.WriteLine("Gün ismi:" + gunIsmi);
