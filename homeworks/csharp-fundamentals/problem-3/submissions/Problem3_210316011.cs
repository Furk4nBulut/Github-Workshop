using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        // YANLIŞ: 0! = 1 kuralı eksik
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;
            for (int i = 1; i <= n; i++) // n=0 için 0 döndürür, 1 olmalı
            {
                sonuc *= i;
            }
            return n == 0 ? 0 : sonuc; // HATA: 0! = 1 olmalı
        }

        // YANLIŞ: İlk iki eleman hatalı
        public static List<long> FibonacciSerisi(int n)
        {
            List<long> seri = new List<long>();
            if (n <= 0) return seri;
            
            seri.Add(1); // HATA: 0 olmalı
            if (n == 1) return seri;
            
            seri.Add(1);
            for (int i = 2; i < n; i++)
            {
                seri.Add(seri[i - 1] + seri[i - 2]);
            }
            return seri;
        }

        // YANLIŞ: Negatif sayılar için çalışmıyor
        public static int BasamakSayisi(int sayi)
        {
            if (sayi == 0) return 1;
            // HATA: Math.Abs kullanılmalı negatifler için
            int count = 0;
            while (sayi != 0)
            {
                sayi /= 10;
                count++;
            }
            return count;
        }

        // YANLIŞ: 2 asal değil diyor
        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            if (sayi == 2) return false; // HATA: 2 asaldır!
            for (int i = 2; i < sayi; i++) // Optimize edilmemiş
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        // YANLIŞ: n dahil değil
        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 1; i < n; i++) // HATA: i <= n olmalı
            {
                toplam += i;
            }
            return toplam;
        }
    }
}
