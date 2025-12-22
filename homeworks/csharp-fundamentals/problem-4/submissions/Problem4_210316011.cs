using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpHomework
{
    public class Problem4
    {
        public static int DiziToplami(int[] dizi)
        {
            int toplam = 0;
            foreach (int i in dizi)
                toplam += i;
            return toplam;
        }

        public static double DiziOrtalamasi(int[] dizi)
        {
            if (dizi.Length == 0) return 0;
            return dizi.Average();
        }

        public static int EnBuyukBul(int[] dizi)
        {
            return dizi.Max();
        }

        public static int EnKucukBul(int[] dizi)
        {
            return dizi.Min();
        }

        public static List<int> CiftSayilariFiltrele(int[] dizi)
        {
            return dizi.Where(x => x % 2 == 0).ToList();
        }

        public static int SayiTekrarSay(int[] dizi, int sayi)
        {
            return dizi.Count(x => x == sayi);
        }
    }
}
