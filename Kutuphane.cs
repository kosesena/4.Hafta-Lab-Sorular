using System;
using System.Collections.Generic;

public class Kitap // Book class
{
    public string Ad { get; set; } // Book Name
    public string Yazar { get; set; } // Author

    public Kitap(string ad, string yazar) // Constructor for Book class
    {
        Ad = ad;
        Yazar = yazar;
    }

    public void BilgiGoster() // Show Book Information
    {
        Console.WriteLine($"Kitap: {Ad}, Yazar: {Yazar}"); // Display Book: {Ad}, Author: {Yazar}
    }
}

public class Kütüphane // Library class
{
    private List<Kitap> Kitaplar; // List of Books
   
    // Constructor - Initializes the book list as empty
    // Yapıcı Metot - Kitaplar listesini boş olarak başlatır
    public Kütüphane()
    {
        Kitaplar = new List<Kitap>();
    }
    
    // Method to add a new book to the list
    // Yeni bir kitabı listeye eklemek için metot
    public void KitapEkle(Kitap yeniKitap)
    {
        Kitaplar.Add(yeniKitap); //Add the new book to the list
        Console.WriteLine($"{yeniKitap.Ad} kütüphaneye eklendi.");// {yeniKitap.Ad} has been added to the library
    }
    
    // Method to list all books in the library
    // Kütüphanedeki tüm kitapları listelemek için metot
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:"); // Books in the Library
        foreach (var kitap in Kitaplar)
        {
            kitap.BilgiGoster(); // Display book information
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the library
        // Kütüphane örneği oluşturma
        Kütüphane kütüphane = new Kütüphane();

        // Add books to the library
        // Kütüphaneye kitap ekleme
        kütüphane.KitapEkle(new Kitap("Sefiller", "Victor Hugo"));//Add "Les Miserables" by Victor Hugo
        kütüphane.KitapEkle(new Kitap("Suç ve Ceza", "Fyodor Dostoyevski"));// Add "Crime and Punishment" by Fyodor Dostoevsky

        // List all books in the library
        // Kütüphanedeki kitapları listeleme
        kütüphane.KitaplariListele();
    }
}
