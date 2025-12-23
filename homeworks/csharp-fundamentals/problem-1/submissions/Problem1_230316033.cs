using System;

namespace CSharpHomework
{
    public class Problem1
    {
        public static double HesaplaOrtalama(int vize, int final)
        {
            return vize * 0.4 + final * 0.6;
        }

        public static string BelirleHarfNotu(double ortalama, int final)
        {
            // Yanlış: Hep AA döndürür
            return "AA";
        }

        public static string BelirleGecmeDurumu(string harfNotu)
        {
            // Yanlış: Hep Kaldı döndürür
            return "Kaldı";
        }
    }
}
