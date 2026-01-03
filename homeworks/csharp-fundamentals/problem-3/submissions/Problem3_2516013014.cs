namespace Problem3_2516013014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyel Hesabı için Sayı Gir");
            int n = Convert.ToInt32(Console.ReadLine());
            long faktoriyelSonuc = Faktoriyel(n);
            Console.WriteLine($"{n}! = {faktoriyelSonuc}");
            Console.WriteLine("Fibonacci Serisi için Sayı Gir");
            int adet = Convert.ToInt32(Console.ReadLine());
            List<int> fibonacciSerisi = FibonacciSerisi(adet);
            Console.WriteLine($"Fibonacci Serisi ({adet} adet): {string.Join(", ", fibonacciSerisi)}");
            Console.WriteLine("Basamak Sayısı için Sayı Gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamakSayisi = BasamakSayisi(sayi);
            Console.WriteLine($"{sayi} sayısının basamak sayısı: {basamakSayisi}");
            Console.WriteLine("Asal Sayı Kontrolü için Sayı Gir");
            int asalSayi = Convert.ToInt32(Console.ReadLine());
            bool asalMi = AsalMi(asalSayi);
            Console.WriteLine(asalMi ? $"{asalSayi} bir asal sayıdır." : $"{asalSayi} bir asal sayı değildir.");
            Console.WriteLine("1'den N'e Kadar Olan Sayıların Toplamı için N Gir");
            int m = Convert.ToInt32(Console.ReadLine());
            int toplam = SayilarinToplami(m);
            Console.WriteLine($"1'den {m}'e kadar olan sayıların toplamı: {toplam}");
            
        }

        public static long Faktoriyel(int n)
        {
            if (n < 0)
                Console.WriteLine("Negatif sayilarin faktoriyeli hesaplanamaz.");
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

            // Negatif veya 0 girilirse boş liste dön
            if (adet <= 0)
                return fibonacci;

            fibonacci.Add(0);

            // Sadece 1 adet istenirse dön
            if (adet == 1)
                return fibonacci;

            fibonacci.Add(1);

           
            int i = 2; // Başlangıç değeri
            while (i < adet)
            {
                int sonraki = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(sonraki);
                i++; // Artırma işlemi
            }

            return fibonacci;
        }

        public static int BasamakSayisi(int adet) {             
            if (adet < 0)
                adet = -adet; // Negatif sayılar için pozitif yap
            if (adet == 0)
                return 1; // 0'ın basamak sayısı 1'dir
            int basamakSayisi = 0;
            while (adet > 0)
            {
                adet /= 10;
                basamakSayisi++;
            }
            return basamakSayisi;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                    return false;
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
