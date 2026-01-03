using System;

namespace CSharpHomework
{
    public class Problem2
    {
        public static string GunAdiGetir(int gunNumarasi)
        {
            switch (gunNumarasi)
            {
                case 1: return "Pazartesi";
                case 2: return "Salı";
                case 3: return "Çarşamba";
                case 4: return "Perşembe";
                case 5: return "Cuma";
                case 6: return "Cumartesi";
                case 7: return "Pazar";
                default: return "Geçersiz gün";
            }
        }

        public static bool ArtikYilMi(int yil)
        {
            if (yil % 400 == 0) return true;
            if (yil % 100 == 0) return false;
            if (yil % 4 == 0) return true;
            return false;
        }

        public static int AyinGunSayisi(int ay, int yil)
        {
            switch (ay)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    if (ArtikYilMi(yil))
                        return 29;
                    else
                        return 28;

                default:
                    return 0;
            }
        }

        public static string HaftaIciSonuMu(int gunNumarasi)
        {
            return (gunNumarasi == 6 || gunNumarasi == 7) ? "Hafta Sonu" : "Hafta İçi";
        }
    }
}