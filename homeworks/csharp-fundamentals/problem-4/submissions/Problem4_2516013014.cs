namespace Problem4_2516013014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi İşlemleri Programı");
            int[] sayilar = { 5, 12, 7, 3, 9, 14, 6, 8, 10, 2, 7 };
            Console.WriteLine("Dizi Elemanları: " + string.Join(", ", sayilar));
            Console.WriteLine("Dizi Toplamı: " + DiziToplami(sayilar));
            Console.WriteLine("Dizi Ortalaması: " + DiziOrtalamasi(sayilar));
            Console.WriteLine("En Büyük Sayı: " + EnBuyukBul(sayilar));
            Console.WriteLine("En Küçük Sayı: " + EnKucukBul(sayilar));
            Console.WriteLine("Çift Sayılar: " + string.Join(", ", CiftSayilariFiltrele(sayilar)));
            int arananSayi = 7;
            Console.WriteLine($"Dizide {arananSayi} sayısının tekrar sayısı: " + SayiTekrarSay(sayilar, arananSayi));
        }

        public static int DiziToplami(int[] dizi)
        {
            int toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam;
        }

        public static int DiziOrtalamasi(int[] dizi)
        {
            int toplam = DiziToplami(dizi);
            return toplam / dizi.Length;
        }

        public static int EnBuyukBul(int[] dizi)
        {
            int enBuyuk = dizi[0];
            foreach (int sayi in dizi)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            return enBuyuk;
        }

        public static int EnKucukBul(int[] dizi)
        {
            int enKucuk = dizi[0];
            foreach (int sayi in dizi)
            {
                if (sayi < enKucuk)
                {
                    enKucuk = sayi;
                }
            }
            return enKucuk;
        }

        public static List<int> CiftSayilariFiltrele(int[] dizi)
        {
            List<int> ciftSayilar = new List<int>();
            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0)
                {
                    ciftSayilar.Add(sayi);
                }
            }
            return ciftSayilar;
        }

        public static int SayiTekrarSay(int[] dizi, int aranan)
        {
            int tekrarSayisi = 0;
            foreach (int eleman in dizi)
            {
                if (eleman == aranan)
                {
                    tekrarSayisi++;
                }
            }
            return tekrarSayisi;

        }
    }
}
