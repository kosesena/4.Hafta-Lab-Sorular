using System;

public class BankaHesabi
{
    // Properties
    // Özellikler
    public string HesapNumarasi { get; private set; }//AccountNumber
    private decimal bakiye; // balance

    // A set method that is accessible only within the class
    // Sadece sınıf içinden erişilebilen set metodu
    public decimal Bakiye
    {
        get { return bakiye; }
        private set { bakiye = value; }
    }
    // Constructor method
    // Yapıcı Metot
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye) //BankAccount
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }
    // Deposit method
    // Para Yatırma Metodu
    public void ParaYatir(decimal miktar) // Deposit
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Güncel Bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Geçersiz miktar. Lütfen pozitif bir değer giriniz.");
        }
    }

    // Para Çekme Metodu
    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Güncel Bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar. İşlem yapılamadı.");
        }
    }
}
class Program
{
    static void Main()
    {
        // Yeni banka hesabı oluştur
        BankaHesabi hesap = new BankaHesabi("123456", 1000m);

        // Para yatır ve çek
        hesap.ParaYatir(500m);
        hesap.ParaCek(200m);
        hesap.ParaCek(1500m); // Yetersiz bakiye durumu

        // Ekranın kapanmaması için bekle
        Console.ReadLine();
    }
}
