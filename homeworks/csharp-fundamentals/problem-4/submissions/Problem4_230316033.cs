using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem4
    {
        public static int DiziToplami(int[] dizi)
        {
            if (dizi == null) return 0;
            int toplam = 0;
            foreach (int sayi in dizi)
                toplam += sayi;
            return toplam;
        }

        public static double DiziOrtalamasi(int[] dizi)
        {
            // Yanlış: Hep 0
            return 0.0;
        }

        public static int EnBuyukBul(int[] dizi)
        {
            // Yanlış: Min değer
            return int.MinValue;
        }

        public static int EnKucukBul(int[] dizi)
        {
            // Yanlış: Max değer
            return int.MaxValue;
        }

        public static List<int> CiftSayilariFiltrele(int[] dizi)
        {
            // Yanlış: Boş liste
            return new List<int>();
        }

        public static int SayiTekrarSay(int[] dizi, int aranan)
        {
            // Yanlış: Hep 0
            return 0;
        }
    }
}
