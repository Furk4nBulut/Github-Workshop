using System;
using System.Collections.Generic; 
namespace CSharpHomework
{
    public class Problem3
    {
        // 1. Faktoriyel Metodu 
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;

            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        // 2. FibonacciSerisi Metodu 
        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> seri = new List<int>();
            
            int a = 0;
            int b = 1;
            int sayac = 0;

            while (sayac < adet)
            {
                seri.Add(a); 

                int sonraki = a + b;
                
                a = b;
                b = sonraki;

                sayac++;
            }

            return seri;
        }

        // 3. BasamakSayisi Metodu 
        public static int BasamakSayisi(int sayi)
        {
            sayi = Math.Abs(sayi);
            
            int basamak = 0;

            do
            {
                sayi = sayi / 10; 
                basamak++;        
            } while (sayi > 0);  

            return basamak;
        }

        // 4. AsalMi Metodu 
        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // 5. SayilarinToplami Metodu 
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
