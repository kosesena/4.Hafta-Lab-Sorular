using System;

public class Kisi
{
    // Özellikler
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string TelefonNumarasi { get; private set; }

    // Yapıcı Metot
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

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
        // Yeni bir kişi oluştur
        Kisi kisi = new Kisi("Sena", "Köse", "0505 xxx xxxx");

        // Kişi bilgilerini göster
        Console.WriteLine(kisi.KisiBilgisi());

        Console.ReadLine();
    }
}