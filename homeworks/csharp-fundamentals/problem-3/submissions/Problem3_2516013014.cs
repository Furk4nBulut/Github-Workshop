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
            {
                sonuc *= i;
            }
            return sonuc;
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> fibonacci = new List<int>();

            if (adet <= 0) return fibonacci;

            fibonacci.Add(0);
            if (adet == 1) return fibonacci;

            fibonacci.Add(1);
            if (adet == 2) return fibonacci;

            for (int i = 2; i < adet; i++)
            {
                int sonraki = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(sonraki);
            }

            return fibonacci;
        }

        public static int BasamakSayisi(int sayi)
        {
            if (sayi == 0) return 1;

            if (sayi < 0) sayi = -sayi;

            int basamakSayisi = 0;
            while (sayi > 0)
            {
                sayi /= 10;
                basamakSayisi++;
            }
            return basamakSayisi;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }
            return toplam;
        }
    }
}