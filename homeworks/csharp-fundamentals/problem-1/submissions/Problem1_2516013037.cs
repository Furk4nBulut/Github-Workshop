using System;

namespace CSharpHomework
{
    public class Problem1
    {
        public static double HesaplaOrtalama(int vize, int final)
        {

            double ortalama = (vize * 0.4) + (final * 0.6);
            return ortalama;

        }

        public static string BelirleHarfNotu(double ortalama, int final)
        {



            if (final < 50)
            {
                return "FF";
            }
            else if (ortalama >= 90 && ortalama <= 100)
            {
                return "AA";
            }
            else if (ortalama >= 85 && ortalama < 90)
            {
                return "BA";
            }
            else if (ortalama >= 80 && ortalama < 85)
            {
                return "BB";
            }
            else if (ortalama >= 75 && ortalama < 80)
            {
                return "CB";
            }
            else if (ortalama >= 70 && ortalama < 75)
            {
                return "CC";
            }
            else if (ortalama >= 65 && ortalama < 70)
            {
                return "DC";
            }
            else if (ortalama >= 60 && ortalama < 65)
            {
                return "DD";
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                return "FD";
            }
            else
            {
                return "FF";
            }           

        }

        public static string BelirleGecmeDurumu(string harfNotu)
        {

            if (harfNotu == "AA" || harfNotu == "BA" || harfNotu == "BB" || harfNotu == "CB" || harfNotu == "CC")
            {
                return "Geçti";
            }
            else if (harfNotu == "DC" || harfNotu == "DD")
            {
                return "Şartlı Geçti";
            }
            else
            {
                return "Kaldı";
            }

        }


    }
}
