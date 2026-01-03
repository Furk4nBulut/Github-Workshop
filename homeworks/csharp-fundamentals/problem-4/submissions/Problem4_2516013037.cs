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
                       
            double toplam = (double)DiziToplami(dizi);

            return toplam / dizi.Length;

        }

        public static int EnBuyukBul(int[] dizi)
        {
            int enBuyuk = int.MinValue;

            foreach (int i in dizi)
            {
                enBuyuk = Math.Max(enBuyuk, i);
            }

            return enBuyuk;
        }

        public static int EnKucukBul(int[] dizi)
        {
            int enKucuk = int.MaxValue;

            foreach (int x in dizi)
            {
                enKucuk = Math.Min(enKucuk, x);
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

            int sayac = 0;

            foreach (int x in dizi)
            {
                sayac += Convert.ToInt32(x == aranan);
            }

            return sayac;

        }
    }
}