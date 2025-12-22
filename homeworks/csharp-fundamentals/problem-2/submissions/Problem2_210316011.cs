using System;

namespace CSharpHomework
{
    public class Problem2
    {
        // YANLIŞ: Türkçe karakterler yok ve bazı günler eksik
        public static string GunAdiGetir(int gun)
        {
            switch (gun)
            {
                case 1: return "Pazartesi";
                case 2: return "Sali"; // HATA: "Salı" olmalı
                case 3: return "Carsamba"; // HATA: "Çarşamba" olmalı
                case 4: return "Persembe"; // HATA: "Perşembe" olmalı
                default: return "Bilinmiyor"; // HATA: "Geçersiz gün" olmalı
            }
        }

        // YANLIŞ: 400'e bölünme kuralı yok
        public static bool ArtikYilMi(int yil)
        {
            return yil % 4 == 0; // HATA: 100 ve 400 kuralları eksik
        }

        // YANLIŞ: Şubat için artık yıl kontrolü yok
        public static int AyinGunSayisi(int ay, int yil)
        {
            if (ay == 2) return 28; // HATA: Artık yıl kontrolü yok
            if (ay == 4 || ay == 6 || ay == 9 || ay == 11) return 30;
            return 31; // Geçersiz ay kontrolü yok
        }

        // YANLIŞ: Yanlış döndürüyor
        public static string HaftaIciSonuMu(int gun)
        {
            if (gun >= 1 && gun <= 5)
                return "Hafta ici"; // HATA: "Hafta İçi" olmalı (büyük İ)
            return "Hafta sonu"; // HATA: "Hafta Sonu" olmalı
        }
    }
}
