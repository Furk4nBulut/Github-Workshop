using System;

namespace CSharpHomework
{
    public class Problem2
    {
        public static string GunAdiGetir(int gun)
        {
            switch (gun)
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
            return yil % 4 == 0;
        }

        public static int AyinGunSayisi(int ay, int yil)
        {
            if (ay < 1 || ay > 12) return 0;

            switch (ay)
            {
                case 2:
                    return ArtikYilMi(yil) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        public static string HaftaIciSonuMu(int gun)
        {
            if (gun >= 1 && gun <= 5) return "Hafta İçi";
            if (gun == 6 || gun == 7) return "Hafta Sonu";
            return "Geçersiz gün";
        }
    }
}
