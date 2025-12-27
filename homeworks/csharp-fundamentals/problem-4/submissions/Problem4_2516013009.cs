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
            if (dizi.Length == 0)
            {
                return 0;
            }

            int toplam = DiziToplami(dizi);
            return (double)toplam / dizi.Length;
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
            List<int> ciftler = new List<int>();
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
