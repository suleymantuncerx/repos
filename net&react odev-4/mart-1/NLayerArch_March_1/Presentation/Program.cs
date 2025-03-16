using DataAccess.Concretes;
using Business.Concretes;
using Entities; // Add this using directive

var programmingLanguageRepo = new ProgrammingLanguageRepository();
var programmingLanguageManager = new ProgrammingLanguageManager(programmingLanguageRepo);

while (true)
{
    Console.WriteLine("\n1 - Programlama Dili Ekle");
    Console.WriteLine("2 - Programlama Dillerini Listele");
    Console.WriteLine("0 - Çıkış");
    Console.Write("Seçiminiz: ");

    string secim = Console.ReadLine();

    if (secim == "1")
    {
        Console.Write("Programlama dili adı girin: ");
        string name = Console.ReadLine();

        programmingLanguageManager.Add(new ProgrammingLanguage
        {
            Id = new Random().Next(1, 100),
            Name = name
        });
    }
    else if (secim == "2")
    {
        programmingLanguageManager.GetAll();
    }
    else if (secim == "0")
    {
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz seçim! Tekrar deneyin.");
    }
}