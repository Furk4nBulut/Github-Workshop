using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem4
    {
        public static int DiziToplami(int[] dizi)
        {
            int toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam;
        }

        public static double DiziOrtalamasi(int[] dizi)
        {
            if (dizi == null || dizi.Length == 0)
                return 0;

            double toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam / dizi.Length;
        }

        public static int EnBuyukBul(int[] dizi)
        {
            if (dizi == null || dizi.Length == 0)
                return 0;

            int enBuyuk = dizi[0];
            foreach (int sayi in dizi)
            {
                if (sayi > enBuyuk)
                    enBuyuk = sayi;
            }
            return enBuyuk;
        }

        public static int EnKucukBul(int[] dizi)
        {
            if (dizi == null || dizi.Length == 0)
                return 0;

            int enKucuk = dizi[0];
            foreach (int sayi in dizi)
            {
                if (sayi < enKucuk)
                    enKucuk = sayi;
            }
            return enKucuk;
        }

        public static List<int> CiftSayilariFiltrele(int[] dizi)
        {
            List<int> ciftler = new List<int>();
            if (dizi == null) return ciftler;

            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0)
                {
                    ciftler.Add(sayi);
                }
            }
            return ciftler;
        }

        public static int SayiTekrarSay(int[] dizi, int aranan)
        {
            int sayac = 0;
            if (dizi == null) return 0;

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
