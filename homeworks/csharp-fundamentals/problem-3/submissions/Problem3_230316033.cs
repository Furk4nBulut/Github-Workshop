using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        public static long Faktoriyel(int n)
        {
            if (n < 0) return 0;
            if (n == 0 || n == 1) return 1;
            long sonuc = 1;
            for (int i = 2; i <= n; i++)
                sonuc *= i;
            return sonuc;
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            // Yanlış: Boş liste
            return new List<int>();
        }

        public static int BasamakSayisi(int sayi)
        {
            // Yanlış: Hep 1
            return 1;
        }

        public static bool AsalMi(int sayi)
        {
            // Yanlış: Hep false
            return false;
        }

        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++)
                toplam += i;
            return toplam;
        }
    }
}
