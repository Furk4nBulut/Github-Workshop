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
            if (dizi.Length == 0) return 0;

            double toplam = DiziToplami(dizi);
            return toplam / dizi.Length;
        }

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