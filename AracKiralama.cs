﻿using System;

public class KiralikArac
{
    // Properties
    // Özellikler
    public string Plaka { get; private set; } // Plate
    public decimal GunlukUcret { get; private set; } // DailyWage
    public bool MusaitMi { get; private set; } // IsAvailable
    
    // Constructor Method
    // Yapıcı Metot
    public KiralikArac(string plaka, decimal gunlukUcret) // RentalCar
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait
    }
    // Method to Rent the Car
    // Aracı Kiralama Metodu
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"Araç {Plaka} kiralandı.");// Car with license plate {Plaka} has been rented. 
        }
        else
        {
            Console.WriteLine($"Araç {Plaka} şu anda müsait değil.");// Car with licence plate {Plaka} is not available at the moment.
        }
    }
    // Method to Return the Car
    // Aracı Teslim Etme Metodu
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;
            Console.WriteLine($"Araç {Plaka} teslim edildi ve artık müsait.");// Car with license plate{Plaka} has been returned and is now available.
        }
        else
        {
            Console.WriteLine($"Araç {Plaka} zaten müsait durumda.");// Car with license plate{Plaka} is already available.
        }
    }
}
class Program
{
    static void Main()
    {
        // Create a new rental car
        // Yeni bir kiralık araç oluştur
        KiralikArac arac = new KiralikArac("34 SK 3454", 100m);
        
        // Rent the car
        // Aracı kirala 
        arac.AraciKirala(); // Aracın kiralanması
        arac.AraciKirala(); // This will display a message that the car is already rented / Zaten kiralandığı için müsait değil uyarısı verecek
        
        // Return the car
        // Aracı teslim et
        arac.AraciTeslimEt(); // Aracın teslim edilmesi
        arac.AraciTeslimEt(); // This will display a message that the car is already available / Zaten müsait olduğu için uyarı verecek

        Console.ReadLine();
    }
}
