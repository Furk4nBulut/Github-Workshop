using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 3 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// 
    /// Puanlama:
    /// - Faktoriyel: 5 puan
    /// - FibonacciSerisi: 6 puan
    /// - BasamakSayisi: 5 puan
    /// - AsalMi: 5 puan
    /// - SayilarinToplami: 4 puan
    /// - TOPLAM: 25 puan
    /// </summary>
    public class Problem3Tests
    {
        // Sayaçlar
        public static int FaktoriyelGecen = 0, FaktoriyelKalan = 0;
        public static int FibonacciGecen = 0, FibonacciKalan = 0;
        public static int BasamakGecen = 0, BasamakKalan = 0;
        public static int AsalGecen = 0, AsalKalan = 0;
        public static int ToplamGecen = 0, ToplamKalan = 0;

        // Puan ağırlıkları
        const double FAKTORIYEL_MAX = 5.0;
        const double FIBONACCI_MAX = 6.0;
        const double BASAMAK_MAX = 5.0;
        const double ASAL_MAX = 5.0;
        const double TOPLAM_MAX = 4.0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║         Problem 3 - Test Sistemi                 ║");
            Console.WriteLine("║         Döngüler ve Matematik                    ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine("║  Bölüm                    │ Max Puan             ║");
            Console.WriteLine("║  ─────────────────────────┼──────────────────────║");
            Console.WriteLine("║  Faktoriyel               │ 5 puan               ║");
            Console.WriteLine("║  FibonacciSerisi          │ 6 puan               ║");
            Console.WriteLine("║  BasamakSayisi            │ 5 puan               ║");
            Console.WriteLine("║  AsalMi                   │ 5 puan               ║");
            Console.WriteLine("║  SayilarinToplami         │ 4 puan               ║");
            Console.WriteLine("║  ─────────────────────────┼──────────────────────║");
            Console.WriteLine("║  TOPLAM                   │ 25 puan              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝\n");

            if (args.Length == 0)
            {
                Console.WriteLine("❌ HATA: Çözüm dosyası belirtilmedi!");
                Environment.Exit(1);
            }

            if (!DosyaAdiKontrol(args[0])) Environment.Exit(1);

            Console.WriteLine("\n" + new string('═', 50));
            Console.WriteLine("📝 TESTLER BAŞLIYOR");
            Console.WriteLine(new string('═', 50) + "\n");

            TestFaktoriyel();
            TestFibonacci();
            TestBasamakSayisi();
            TestAsalMi();
            TestSayilarinToplami();

            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem3_(\d+)\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem3_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestFaktoriyel()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 1: Faktoriyel (5 puan)                  │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int n, long beklenen)[] {
                (0, 1), (1, 1), (5, 120), (10, 3628800)
            };

            foreach (var (n, beklenen) in testler)
            {
                try
                {
                    long sonuc = Problem3.Faktoriyel(n);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {n}! → {beklenen}");
                        FaktoriyelGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {n}! → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        FaktoriyelKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {n}! → Hata: {ex.Message}");
                    FaktoriyelKalan++;
                }
            }

            int t = FaktoriyelGecen + FaktoriyelKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {FaktoriyelGecen}/{t} test geçti\n");
        }

        static void TestFibonacci()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 2: FibonacciSerisi (6 puan)             │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            // Test 1: 5 eleman
            try
            {
                var fib5 = Problem3.FibonacciSerisi(5);
                if (fib5.Count == 5)
                {
                    Console.WriteLine($"   ✅ FibonacciSerisi(5) → 5 eleman döndü");
                    FibonacciGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ FibonacciSerisi(5) → Beklenen: 5 eleman, Bulunan: {fib5.Count}");
                    FibonacciKalan++;
                }

                if (fib5.Count > 0 && fib5[0] == 0)
                {
                    Console.WriteLine($"   ✅ fib[0] = 0");
                    FibonacciGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ fib[0] → Beklenen: 0");
                    FibonacciKalan++;
                }

                if (fib5.Count > 1 && fib5[1] == 1)
                {
                    Console.WriteLine($"   ✅ fib[1] = 1");
                    FibonacciGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ fib[1] → Beklenen: 1");
                    FibonacciKalan++;
                }

                if (fib5.Count > 4 && fib5[4] == 3)
                {
                    Console.WriteLine($"   ✅ fib[4] = 3");
                    FibonacciGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ fib[4] → Beklenen: 3");
                    FibonacciKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ FibonacciSerisi(5) → Hata: {ex.Message}");
                FibonacciKalan += 4;
            }

            // Test 2: 8 eleman
            try
            {
                var fib8 = Problem3.FibonacciSerisi(8);
                if (fib8.Count > 7 && fib8[7] == 13)
                {
                    Console.WriteLine($"   ✅ fib[7] = 13");
                    FibonacciGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ fib[7] → Beklenen: 13");
                    FibonacciKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ FibonacciSerisi(8) → Hata: {ex.Message}");
                FibonacciKalan++;
            }

            // Test 3: 0 eleman
            try
            {
                var fib0 = Problem3.FibonacciSerisi(0);
                if (fib0.Count == 0)
                {
                    Console.WriteLine($"   ✅ FibonacciSerisi(0) → boş liste");
                    FibonacciGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ FibonacciSerisi(0) → Beklenen: boş, Bulunan: {fib0.Count} eleman");
                    FibonacciKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ FibonacciSerisi(0) → Hata: {ex.Message}");
                FibonacciKalan++;
            }

            int t = FibonacciGecen + FibonacciKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {FibonacciGecen}/{t} test geçti\n");
        }

        static void TestBasamakSayisi()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 3: BasamakSayisi (5 puan)               │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int sayi, int beklenen)[] {
                (0, 1), (5, 1), (12, 2), (12345, 5), (-999, 3), (1000000, 7)
            };

            foreach (var (sayi, beklenen) in testler)
            {
                try
                {
                    int sonuc = Problem3.BasamakSayisi(sayi);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {sayi} → {beklenen} basamak");
                        BasamakGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {sayi} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        BasamakKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {sayi} → Hata: {ex.Message}");
                    BasamakKalan++;
                }
            }

            int t = BasamakGecen + BasamakKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {BasamakGecen}/{t} test geçti\n");
        }

        static void TestAsalMi()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 4: AsalMi (5 puan)                      │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int sayi, bool beklenen)[] {
                (0, false), (1, false), (2, true), (3, true), (4, false),
                (17, true), (18, false), (97, true), (100, false)
            };

            foreach (var (sayi, beklenen) in testler)
            {
                try
                {
                    bool sonuc = Problem3.AsalMi(sayi);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {sayi} → {(beklenen ? "asal" : "asal değil")}");
                        AsalGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {sayi} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        AsalKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {sayi} → Hata: {ex.Message}");
                    AsalKalan++;
                }
            }

            int t = AsalGecen + AsalKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {AsalGecen}/{t} test geçti\n");
        }

        static void TestSayilarinToplami()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 5: SayilarinToplami (4 puan)            │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int n, int beklenen)[] {
                (1, 1), (5, 15), (10, 55), (100, 5050)
            };

            foreach (var (n, beklenen) in testler)
            {
                try
                {
                    int sonuc = Problem3.SayilarinToplami(n);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ 1..{n} toplamı → {beklenen}");
                        ToplamGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ 1..{n} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        ToplamKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ 1..{n} → Hata: {ex.Message}");
                    ToplamKalan++;
                }
            }

            int t = ToplamGecen + ToplamKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {ToplamGecen}/{t} test geçti\n");
        }

        static void Sonuclar()
        {
            int t1 = FaktoriyelGecen + FaktoriyelKalan;
            int t2 = FibonacciGecen + FibonacciKalan;
            int t3 = BasamakGecen + BasamakKalan;
            int t4 = AsalGecen + AsalKalan;
            int t5 = ToplamGecen + ToplamKalan;

            double p1 = t1 > 0 ? (double)FaktoriyelGecen / t1 * FAKTORIYEL_MAX : 0;
            double p2 = t2 > 0 ? (double)FibonacciGecen / t2 * FIBONACCI_MAX : 0;
            double p3 = t3 > 0 ? (double)BasamakGecen / t3 * BASAMAK_MAX : 0;
            double p4 = t4 > 0 ? (double)AsalGecen / t4 * ASAL_MAX : 0;
            double p5 = t5 > 0 ? (double)ToplamGecen / t5 * TOPLAM_MAX : 0;
            double toplam = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║              📊 PUAN TABLOSU                     ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  Faktoriyel       │ {p1,6:F2} / {FAKTORIYEL_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  FibonacciSerisi  │ {p2,6:F2} / {FIBONACCI_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  BasamakSayisi    │ {p3,6:F2} / {BASAMAK_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  AsalMi           │ {p4,6:F2} / {ASAL_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  SayilarinToplami │ {p5,6:F2} / {TOPLAM_MAX,5:F2} puan        ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  TOPLAM PUAN      │ {toplam,6:F2} / 25.00 puan        ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");

            double yuzde = (toplam / 25.0) * 100;
            Console.WriteLine($"\n📈 Başarı Yüzdesi: %{yuzde:F1}");

            if (yuzde >= 100)
                Console.WriteLine("\n🎉 TEBRİKLER! TÜM TESTLER BAŞARILI! FULL PUAN!");
            else if (yuzde >= 80)
                Console.WriteLine("\n✅ Çok iyi! Birkaç küçük düzeltmeyle full puan alabilirsiniz.");
            else if (yuzde >= 50)
                Console.WriteLine("\n⚠️ Orta seviye. Eksik kısımları gözden geçirin.");
            else
                Console.WriteLine("\n❌ Daha fazla çalışma gerekiyor. README'yi tekrar okuyun.");

            if (toplam < 25) Environment.Exit(1);
        }
    }
}
