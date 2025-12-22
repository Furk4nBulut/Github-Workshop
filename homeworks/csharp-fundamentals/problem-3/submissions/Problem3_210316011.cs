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
                sonuc *= i;
            return sonuc;
        }

        public static List<int> FibonacciSerisi(int n)
        {
            List<int> fib = new List<int>();
            if (n <= 0) return fib;

            fib.Add(0);
            if (n == 1) return fib;

            fib.Add(1);
            for (int i = 2; i < n; i++)
                fib.Add(fib[i - 1] + fib[i - 2]);

            return fib;
        }

        public static int BasamakSayisi(int sayi)
        {
            sayi = Math.Abs(sayi);
            if (sayi == 0) return 1;

            int count = 0;
            while (sayi > 0)
            {
                count++;
                sayi /= 10;
            }
            return count;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;

            for (int i = 2; i * i <= sayi; i++)
                if (sayi % i == 0)
                    return false;

            return true;
        }

        public static int SayilarinToplami(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
