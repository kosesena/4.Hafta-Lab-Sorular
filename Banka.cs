using System;

public class BankaHesabi //Bank Account Class
{
    // Properties
    // Özellikler
    public string HesapNumarasi { get; private set; } // AccountNumber
    private decimal bakiye; // balance

    // A set method that is accessible only within the class
    // Sadece sınıf içinden erişilebilen set metodu
    public decimal Bakiye // Balance Property
    {
        get { return bakiye; }
        private set { bakiye = value; }
    }
    // Constructor method
    // Yapıcı Metot
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye) //BankAccount constructor
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }
    // Deposit method
    // Para Yatırma Metodu
    public void ParaYatir(decimal miktar) // Deposit
    {
        if (miktar > 0) // Check if amount is positive
        {
            Bakiye += miktar; // Increase balance
            Console.WriteLine($"{miktar} TL yatırıldı. Güncel Bakiye: {Bakiye} TL"); // {miktar} TL deposited. Current Balance: {Bakiye} TL
        }
        else
        {
            Console.WriteLine("Geçersiz miktar. Lütfen pozitif bir değer giriniz.");// Invalid amount.Please enter a positive value.
        }
    }
    // Withdraw Method
    // Para Çekme Metodu
    public void ParaCek(decimal miktar) // Withdraw
    {
        if (miktar > 0 && miktar <= Bakiye) // Check if amount is positive and within balance
        {
            Bakiye -= miktar; // Decrease balance
            Console.WriteLine($"{miktar} TL çekildi. Güncel Bakiye: {Bakiye} TL"); // {miktar} TL withdrawn. Current Balance: {Bakiye} TL
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar. İşlem yapılamadı.");// Insufficient balance or invalid amount.Transaction not completed.
        }
    }
}
class Program
{
    static void Main()
    {
        // Create a new bank account
        // Yeni banka hesabı oluştur
        BankaHesabi hesap = new BankaHesabi("123456", 1000m);
        //Deposit and Withdraw
        // Para yatır ve çek
        hesap.ParaYatir(500m); // Deposit 500 TL
        hesap.ParaCek(200m); // Withdraw 200 TL
        hesap.ParaCek(1500m); // Yetersiz bakiye durumu - Insufficient balance scenario
        
        // Wait to prevent console from closing
        // Ekranın kapanmaması için bekle
        Console.ReadLine();
    }
}
