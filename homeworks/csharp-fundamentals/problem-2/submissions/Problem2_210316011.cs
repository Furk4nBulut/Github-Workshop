using System;

namespace CSharpHomework
{
    /// <summary>
    /// Problem 2: Haftanın Günü ve Ay Hesaplama
    /// Toplam Puan: 25
    /// </summary>
    public class Problem2
    {
        /// <summary>
        /// Gün numarasına göre gün adını döndürür
        /// switch-case kullanılmalı
        /// Puan: 7
        /// </summary>
        public static string GunAdiGetir(int gunNumarasi)
        {
            switch (gunNumarasi)
            {
                case 1:
                    return "Pazartesi";
                case 2:
                    return "Salı";
                case 3:
                    return "Çarşamba";
                case 4:
                    return "Perşembe";
                case 5:
                    return "Cuma";
                case 6:
                    return "Cumartesi";
                case 7:
                    return "Pazar";
                default:
                    return "Geçersiz gün";
            }
        }

        /// <summary>
        /// Verilen yılın artık yıl olup olmadığını kontrol eder
        /// Kurallar:
        /// 1. Yıl 400'e tam bölünüyorsa → artık yıl
        /// 2. Yıl 100'e tam bölünüyorsa → artık yıl DEĞİL
        /// 3. Yıl 4'e tam bölünüyorsa → artık yıl
        /// 4. Diğer durumlar → artık yıl DEĞİL
        /// Puan: 6
        /// </summary>
        public static bool ArtikYilMi(int yil)
        {
            if (yil % 400 == 0)
                return true;
            else if (yil % 100 == 0)
                return false;
            else if (yil % 4 == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verilen ay ve yıla göre gün sayısını hesaplar
        /// switch-case kullanılmalı
        /// Puan: 7
        /// </summary>
        public static int AyinGunSayisi(int ay, int yil)
        {
            switch (ay)
            {
                case 1:  // Ocak
                case 3:  // Mart
                case 5:  // Mayıs
                case 7:  // Temmuz
                case 8:  // Ağustos
                case 10: // Ekim
                case 12: // Aralık
                    return 31;

                case 4:  // Nisan
                case 6:  // Haziran
                case 9:  // Eylül
                case 11: // Kasım
                    return 30;

                case 2:  // Şubat
                    return ArtikYilMi(yil) ? 29 : 28;

                default: // Geçersiz ay
                    return 0;
            }
        }

        /// <summary>
        /// Günün hafta içi mi hafta sonu mu olduğunu belirler
        /// Ternary operatör kullanılmalı
        /// Puan: 5
        /// </summary>
        public static string HaftaIciSonuMu(int gunNumarasi)
        {
            // 1-5 Hafta İçi, 6-7 Hafta Sonu
            return (gunNumarasi >= 1 && gunNumarasi <= 5) ? "Hafta İçi" : "Hafta Sonu";
        }
    }
}
