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

            List<int> fibSeri = new List<int>();

            int sayi1 = 0;
            int sayi2 = 1;
            int sayac = 0;

            while (sayac < adet)
            {
                fibSeri.Add(sayi1);

                int yeniSayi = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = yeniSayi;

                sayac++;
            }

            return fibSeri;

        }

        public static int BasamakSayisi(int sayi)
        {

            sayi = Math.Abs(sayi);

            int basamak = 0;

            do
            {
                sayi = sayi / 10;
                basamak++;
            }
            while (sayi > 0);

            return basamak;


        }

        public static bool AsalMi(int sayi)
        {

            bool asalDurumu = (sayi >= 2);
                      
            for (int i = 2; i <= Math.Sqrt(sayi) && asalDurumu; i++)
            {
               
                asalDurumu = (sayi % i != 0);
            }

            return asalDurumu;

        }

        public static int SayilarinToplami(int n)
        {

            int toplam = 0;
            
            for (int i = 1; i <= n; i++)
            {
                toplam = toplam + i;
            }

            return toplam;

        }
    }
}