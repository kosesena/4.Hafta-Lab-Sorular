using System;

public class KiralikArac
{
    // Özellikler
    public string Plaka { get; private set; }
    public decimal GunlukUcret { get; private set; }
    public bool MusaitMi { get; private set; }

    // Yapıcı Metot
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait
    }

    // Aracı Kiralama Metodu
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"Araç {Plaka} kiralandı.");
        }
        else
        {
            Console.WriteLine($"Araç {Plaka} şu anda müsait değil.");
        }
    }

    // Aracı Teslim Etme Metodu
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;
            Console.WriteLine($"Araç {Plaka} teslim edildi ve artık müsait.");
        }
        else
        {
            Console.WriteLine($"Araç {Plaka} zaten müsait durumda.");
        }
    }
}
class Program
{
    static void Main()
    {
        // Yeni bir kiralık araç oluştur
        KiralikArac arac = new KiralikArac("34 SK 3454", 100m);

        // Aracı kirala ve teslim et
        arac.AraciKirala(); // Aracın kiralanması
        arac.AraciKirala(); // Zaten kiralandığı için müsait değil uyarısı verecek
        arac.AraciTeslimEt(); // Aracın teslim edilmesi
        arac.AraciTeslimEt(); // Zaten müsait olduğu için uyarı verecek

        Console.ReadLine();
    }
}
