// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





// ŞİFRE İSTENME İŞLEMİ
Console.Write("Şifre girin: ");
string password = Console.ReadLine();

bool hasUpper = false;
bool hasSpecial = false;
string specialChars = "@#$%";

// ŞİFRENİN UZUNLUĞUNU KONTROL EDİLİYOR
if (password.Length >= 8)
{
    // ŞİFRENİN İÇİNDE BÜYÜK HARF VE ÖZEL KARAKTER VAR MI KONTROL EDİYOR
    foreach (char c in password)
    {
        if (char.IsUpper(c))
        {
            hasUpper = true;
        }
        if (specialChars.Contains(c))
        {
            hasSpecial = true;
        }
    }

    // HERŞEY SAĞLANIYORSA

    if (hasUpper && !hasSpecial)
    {
        Console.WriteLine("Şifre Oluşturma Tamamlandı");
    }
    else
    {

    if (hasUpper)
        {
            Console.WriteLine("Şifre en az bir büyük harf içermelidir.");
        }
        if (hasSpecial)
        {
            Console.WriteLine("Şifre özel karakter (@, #, $, %) içermemelidir.");
        }
    }
}
else
{
    Console.WriteLine("Şifre en az 8 karakter uzunluğunda olmalıdır.");

}
