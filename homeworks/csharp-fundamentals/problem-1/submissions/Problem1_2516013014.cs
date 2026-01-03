using System;

namespace CSharpHomework
{
    public class Problem1
    {

       


        public static double HesaplaOrtalama(int vize, int final)
        {
            return (vize * 0.4) + (final * 0.6);
        }


        public static string BelirleHarfNotu(double ortalama, int final)
        {

            if (final < 50)
            {
                return "FF";
            }

            if (ortalama >= 90) return "AA";
            else if (ortalama >= 85) return "BA";
            else if (ortalama >= 80) return "BB";
            else if (ortalama >= 75) return "CB";
            else if (ortalama >= 70) return "CC";
            else if (ortalama >= 65) return "DC";
            else if (ortalama >= 60) return "DD";
            else if (ortalama >= 50) return "FD";
            else return "FF";
        }


        public static string BelirleGecmeDurumu(string harfNotu)
        {
            switch (harfNotu)
            {
                case "AA":
                case "BA":
                case "BB":
                case "CB":
                case "CC":
                    return "Geçti";
                case "DC":
                case "DD":
                    return "Şartlı Geçti";
                default: // FD ve FF durumları
                    return "Kaldı";
            }
        }
    }
}