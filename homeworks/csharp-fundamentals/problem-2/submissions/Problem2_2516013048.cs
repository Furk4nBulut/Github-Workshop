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
            switch (yil % 400)
            {
                case 0:
                    return true;
                default:
                    switch (yil % 100)
                    {
                        case 0:
                            return false;
                        default:
                            switch (yil % 4)
                            {
                                case 0:
                                    return true;
                                default:
                                    return false;
                            }
                    }
            }
        }

        public static int AyinGunSayisi(int ay, int yil)
        {
            switch (ay)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                
                case 4: case 6: case 9: case 11:
                    return 30;
                
                case 2:
                    switch (ArtikYilMi(yil))
                    {
                        case true: return 29;
                        default: return 28;
                    }
                
                default:
                    return 0;
            }
        }

        public static string HaftaIciSonuMu(int gunNumarasi)
        {
            switch (gunNumarasi)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Hafta İçi";
                
                case 6:
                case 7:
                    return "Hafta Sonu";
                
                default:
                    return "Geçersiz gün";
            }
        }
    }
}
