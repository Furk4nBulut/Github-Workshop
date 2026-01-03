using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> serisi = new List<int>();

            if (adet <= 0) return serisi;
            
            serisi.Add(0);
            
            if (adet == 1) return serisi;

            serisi.Add(1);

            int i = 2;
            while (i < adet)
            {
                serisi.Add(serisi[i - 1] + serisi[i - 2]);
                i++;
            }
            return serisi;
        }

        public static int BasamakSayisi(int sayi)
        {
            if (sayi < 0) sayi = -sayi;
            int basamak = 0;

            do
            {
                sayi /= 10;
                basamak++;
            } while (sayi > 0);

            return basamak;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            
            for (int i = 2; i * i <= sayi; i++)
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
