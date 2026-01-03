namespace Problem2_2516013014
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(GunAdiGetir(3)); // Çarşamba
           Console.WriteLine(ArtikYilMi(2020)); // True
           Console.WriteLine(AyniGunSayisi(2, 2021)); // 28
           Console.WriteLine(HaftaIcıSonuMu(6)); // Hafta sonu

        }

       public static string GunAdiGetir(int gunNumarasi)
        {
            return gunNumarasi switch
            {
                1 => "Pazartesi",
                2 => "Salı",
                3 => "Çarşamba",
                4 => "Perşembe",
                5 => "Cuma",
                6 => "Cumartesi",
                7 => "Pazar",
                _ => "Geçersiz gün"
            };
        }

        public static bool ArtikYilMi(int yil)
        {
            return yil % 4 == 0 && (yil % 100 != 0 || yil % 400 == 0);
        }

        public static int AyniGunSayisi(int ay, int yıl) {             
            return ay switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => ArtikYilMi(yıl) ? 29 : 28,
                _ => 0
            };
        }

        public static string HaftaIcıSonuMu(int gunNumarasi)
        {
            string sonuc = (gunNumarasi >= 1 && gunNumarasi <= 5) ? "Hafta içi" :
               (gunNumarasi == 6 || gunNumarasi == 7) ? "Hafta sonu" :
               "Geçersiz gün";

            return sonuc;
        }
    }
}
