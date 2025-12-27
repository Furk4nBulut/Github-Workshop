using System;
using System.Collections.Generic; 
namespace CSharpHomework
{
    public class Problem4
    {
        // 1. DiziToplami Metodu
        public static int DiziToplami(int[] dizi)
        {
            int toplam = 0;

            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }

            return toplam;
        }

        // 2. DiziOrtalamasi Metodu
        public static double DiziOrtalamasi(int[] dizi)
        {
            if (dizi.Length == 0)
            {
                return 0;
            }

            double toplam = DiziToplami(dizi);
            
            return toplam / dizi.Length;
        }

        // 3. EnBuyukBul Metodu
        public static int EnBuyukBul(int[] dizi)
        {
            if (dizi.Length == 0) return 0;

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

        // 4. EnKucukBul Metodu
        public static int EnKucukBul(int[] dizi)
        {
            if (dizi.Length == 0) return 0;

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

        // 5. CiftSayilariFiltrele Metodu 
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

        // 6. SayiTekrarSay Metodu
        public static int SayiTekrarSay(int[] dizi, int aranan)
        {
            int sayac = 0;

            foreach (int sayi in dizi)
            {
                if (sayi == aranan)
                {
                    sayac++;
                }
            }

            return sayac;
        }
    }
}
