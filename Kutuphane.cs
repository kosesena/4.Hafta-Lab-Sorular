using System;
using System.Collections.Generic;

public class Kitap
{
    public string Ad { get; set; }
    public string Yazar { get; set; }

    public Kitap(string ad, string yazar)
    {
        Ad = ad;
        Yazar = yazar;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Kitap: {Ad}, Yazar: {Yazar}");
    }
}

public class Kütüphane
{
    private List<Kitap> Kitaplar;

    // Yapıcı Metot - Kitaplar listesini boş olarak başlatır
    public Kütüphane()
    {
        Kitaplar = new List<Kitap>();
    }

    // Yeni bir kitabı listeye eklemek için metot
    public void KitapEkle(Kitap yeniKitap)
    {
        Kitaplar.Add(yeniKitap);
        Console.WriteLine($"{yeniKitap.Ad} kütüphaneye eklendi.");
    }

    // Kütüphanedeki tüm kitapları listelemek için metot
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            kitap.BilgiGoster();
        }
    }
}

class Program
{
    static void Main()
    {
        // Kütüphane örneği oluşturma
        Kütüphane kütüphane = new Kütüphane();

        // Kütüphaneye kitap ekleme
        kütüphane.KitapEkle(new Kitap("Sefiller", "Victor Hugo"));
        kütüphane.KitapEkle(new Kitap("Suç ve Ceza", "Fyodor Dostoyevski"));

        // Kütüphanedeki kitapları listeleme
        kütüphane.KitaplariListele();
    }
}
