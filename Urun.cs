using System;

public class Urun
{
    // Özellikler
    public string Ad { get; private set; }
    public decimal Fiyat { get; private set; }
    private decimal indirim;

    // İndirim özelliği (0 ile 50 arasında olmasını sağlayan kontrol)
    public decimal Indirim
    {
        get { return indirim; }
        set
        {
            if (value >= 0 && value <= 50)
                indirim = value;
            else
                throw new ArgumentOutOfRangeException("İndirim %0 ile %50 arasında olmalıdır.");
        }
    }

    // Yapıcı Metot
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
        Indirim = 0; // Varsayılan olarak indirim %0
    }

    // İndirimli Fiyatı Döndüren Metot
    public decimal IndirimliFiyat()
    {
        return Fiyat * (1 - (Indirim / 100));
    }
}
class Program
{
    static void Main()
    {
        // Yeni ürün oluştur
        Urun urun = new Urun("Laptop", 5000m);

        // İndirim oranını ayarla
        urun.Indirim = 20; // %20 indirim

        // İndirimli fiyatı göster
        Console.WriteLine($"Ürün Adı: {urun.Ad}");
        Console.WriteLine($"Orijinal Fiyat: {urun.Fiyat} TL");
        Console.WriteLine($"İndirimli Fiyat: {urun.IndirimliFiyat()} TL");

        Console.ReadLine();
    }
}