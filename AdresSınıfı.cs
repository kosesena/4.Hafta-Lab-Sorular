using System;

public class Kisi
{
    // Properties
    // Özellikler
    public string Ad { get; private set; } // Name
    public string Soyad { get; private set; } // Surname
    public string TelefonNumarasi { get; private set; } //PhoneNumber
    
    // Constructor Method
    // Yapıcı Metot
    public Kisi(string ad, string soyad, string telefonNumarasi) // Person
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }
    
    // Person Information Method
    // Kişi Bilgisi Metodu
    public string KisiBilgisi()
    {
        return $"Ad Soyad: {Ad} {Soyad}, Telefon Numarası: {TelefonNumarasi}";
    }
}
class Program
{
    static void Main()
    {
        // Create a new person
        // Yeni bir kişi oluştur
        Kisi kisi = new Kisi("Sena", "Köse", "0505 xxx xxxx");
        
        // Display person information
        // Kişi bilgilerini göster
        Console.WriteLine(kisi.KisiBilgisi());

        Console.ReadLine();
    }
}
