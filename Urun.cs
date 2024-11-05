using System;

public class Urun
{
    // Constructor
    // Özellikler
    public string Ad { get; private set; } // Name
    public decimal Fiyat { get; private set; } // Price
    private decimal indirim; // Discount

    // Discount property (Ensures the discount is between 0 and 50)
    // İndirim özelliği (0 ile 50 arasında olmasını sağlayan kontrol)
    public decimal Indirim
    {
        get { return indirim; }
        set
        {
            if (value >= 0 && value <= 50)
                indirim = value;
            else
                throw new ArgumentOutOfRangeException("İndirim %0 ile %50 arasında olmalıdır."); // "Discount must be between 0% and 50%."
        }
    }
    // Constructor method
    // Yapıcı Metot
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
        Indirim = 0; // Varsayılan olarak indirim %0 - Default discount is set to 0
    }
   
    // Method to return the discounted price
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
        // Create a new product
        // Yeni ürün oluştur
        Urun urun = new Urun("Laptop", 5000m);

        // Set discount rate
        // İndirim oranını ayarla
        urun.Indirim = 20; // %20 indirim - Set a 20% discount

        //Display discounted price
        // İndirimli fiyatı göster
        Console.WriteLine($"Ürün Adı: {urun.Ad}"); // Product Name
        Console.WriteLine($"Orijinal Fiyat: {urun.Fiyat} TL"); // Original Price
        Console.WriteLine($"İndirimli Fiyat: {urun.IndirimliFiyat()} TL"); // Discounted Price

        Console.ReadLine();
    }
}
