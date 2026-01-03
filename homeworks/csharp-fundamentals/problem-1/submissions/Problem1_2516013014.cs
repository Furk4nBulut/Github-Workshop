namespace Problem1_2516013014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize Notunu Giriniz: ");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notunu Giriniz: ");
            double final = Convert.ToDouble(Console.ReadLine());
            double ortalama = HesaplaOrtalama(vize, final);
            string harfNotu = HarfNotuBelirle(ortalama);
            string gecmeDurumu = BelirleGecmeDurumu(harfNotu);

            Console.WriteLine($"Ortalama: {ortalama}");
            Console.WriteLine($"Harf Notu: {harfNotu}");
            Console.WriteLine($"Geçme Durumu: {gecmeDurumu}");
        }

        public static double HesaplaOrtalama(double vize, double final)
        {
            return (vize * 0.4) + (final * 0.6);
        }

        public static string HarfNotuBelirle(double ortalama)
        {
            if (ortalama >= 90)
                return "AA";
            else if (ortalama >= 85)
                return "BA";
            else if (ortalama >= 80)
                return "BB";
            else if (ortalama >= 75)
                return "CB";
            else if (ortalama >= 70)
                return "CC";
            else if (ortalama >= 65)
                return "DC";
            else if (ortalama >= 60)
                return "DD";
            else if (ortalama >= 50)
                return "FD";
            else
                return "FF";
        }

        public static string BelirleGecmeDurumu(string harfNotu)
        {
            switch(harfNotu)
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
                default:
                    return "Kaldı";
            }
        }
    }
}
