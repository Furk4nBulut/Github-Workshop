using System;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 1 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// 
    /// Puanlama:
    /// - HesaplaOrtalama: 8 puan
    /// - BelirleHarfNotu: 10 puan  
    /// - BelirleGecmeDurumu: 7 puan
    /// - TOPLAM: 25 puan
    /// </summary>
    public class Problem1Tests
    {
        // Her bölüm için puanlar
        public static double HesaplaOrtalamaPuan = 0;
        public static double BelirleHarfNotuPuan = 0;
        public static double BelirleGecmeDurumuPuan = 0;

        public static int HesaplaOrtalamaGecen = 0;
        public static int HesaplaOrtalamaKalan = 0;
        public static int BelirleHarfNotuGecen = 0;
        public static int BelirleHarfNotuKalan = 0;
        public static int BelirleGecmeDurumuGecen = 0;
        public static int BelirleGecmeDurumuKalan = 0;

        // Puan ağırlıkları
        const double HESAPLA_ORTALAMA_MAX = 8.0;
        const double BELIRLE_HARF_NOTU_MAX = 10.0;
        const double BELIRLE_GECME_DURUMU_MAX = 7.0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║         Problem 1 - Test Sistemi                 ║");
            Console.WriteLine("║         Öğrenci Not Hesaplama                    ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine("║  Bölüm                    │ Max Puan             ║");
            Console.WriteLine("║  ─────────────────────────┼──────────────────────║");
            Console.WriteLine("║  HesaplaOrtalama          │ 8 puan               ║");
            Console.WriteLine("║  BelirleHarfNotu          │ 10 puan              ║");
            Console.WriteLine("║  BelirleGecmeDurumu       │ 7 puan               ║");
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

            // Testler
            TestHesaplaOrtalama();
            TestBelirleHarfNotu();
            TestBelirleGecmeDurumu();

            // Puanları hesapla
            HesaplaPuanlar();

            // Sonuçları göster
            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem1_(\d+)\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem1_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestHesaplaOrtalama()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 1: HesaplaOrtalama (8 puan)             │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            // Test 1
            try
            {
                double r1 = Problem1.HesaplaOrtalama(70, 80);
                if (Math.Abs(r1 - 76.0) < 0.01)
                {
                    Console.WriteLine("   ✅ Test 1: vize=70, final=80 → 76.0");
                    HesaplaOrtalamaGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ Test 1: Beklenen 76.0, Bulunan {r1:F2}");
                    HesaplaOrtalamaKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Test 1: Hata - {ex.Message}");
                HesaplaOrtalamaKalan++;
            }

            // Test 2
            try
            {
                double r2 = Problem1.HesaplaOrtalama(100, 100);
                if (Math.Abs(r2 - 100.0) < 0.01)
                {
                    Console.WriteLine("   ✅ Test 2: vize=100, final=100 → 100.0");
                    HesaplaOrtalamaGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ Test 2: Beklenen 100.0, Bulunan {r2:F2}");
                    HesaplaOrtalamaKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Test 2: Hata - {ex.Message}");
                HesaplaOrtalamaKalan++;
            }

            // Test 3
            try
            {
                double r3 = Problem1.HesaplaOrtalama(50, 50);
                if (Math.Abs(r3 - 50.0) < 0.01)
                {
                    Console.WriteLine("   ✅ Test 3: vize=50, final=50 → 50.0");
                    HesaplaOrtalamaGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ Test 3: Beklenen 50.0, Bulunan {r3:F2}");
                    HesaplaOrtalamaKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Test 3: Hata - {ex.Message}");
                HesaplaOrtalamaKalan++;
            }

            // Test 4
            try
            {
                double r4 = Problem1.HesaplaOrtalama(0, 0);
                if (Math.Abs(r4 - 0.0) < 0.01)
                {
                    Console.WriteLine("   ✅ Test 4: vize=0, final=0 → 0.0");
                    HesaplaOrtalamaGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ Test 4: Beklenen 0.0, Bulunan {r4:F2}");
                    HesaplaOrtalamaKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Test 4: Hata - {ex.Message}");
                HesaplaOrtalamaKalan++;
            }

            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {HesaplaOrtalamaGecen}/4 test geçti\n");
        }

        static void TestBelirleHarfNotu()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 2: BelirleHarfNotu (10 puan)            │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            string[] testler = {
                "95,90,AA", "87,85,BA", "82,80,BB", "77,75,CB", "72,70,CC",
                "67,65,DC", "62,60,DD", "55,55,FD", "40,50,FF", "80,49,FF", "95,30,FF"
            };

            foreach (var test in testler)
            {
                var parts = test.Split(',');
                double ort = double.Parse(parts[0]);
                int final = int.Parse(parts[1]);
                string beklenen = parts[2];

                try
                {
                    string sonuc = Problem1.BelirleHarfNotu(ort, final);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ ort={ort}, final={final} → {beklenen}");
                        BelirleHarfNotuGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ ort={ort}, final={final} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        BelirleHarfNotuKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ ort={ort}, final={final} → Hata: {ex.Message}");
                    BelirleHarfNotuKalan++;
                }
            }

            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {BelirleHarfNotuGecen}/11 test geçti\n");
        }

        static void TestBelirleGecmeDurumu()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 3: BelirleGecmeDurumu (7 puan)          │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            string[] testler = {
                "AA,Geçti", "BA,Geçti", "BB,Geçti", "CB,Geçti", "CC,Geçti",
                "DC,Şartlı Geçti", "DD,Şartlı Geçti", "FD,Kaldı", "FF,Kaldı"
            };

            foreach (var test in testler)
            {
                var parts = test.Split(',');
                string harf = parts[0];
                string beklenen = parts[1];

                try
                {
                    string sonuc = Problem1.BelirleGecmeDurumu(harf);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {harf} → {beklenen}");
                        BelirleGecmeDurumuGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {harf} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        BelirleGecmeDurumuKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {harf} → Hata: {ex.Message}");
                    BelirleGecmeDurumuKalan++;
                }
            }

            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {BelirleGecmeDurumuGecen}/9 test geçti\n");
        }

        static void HesaplaPuanlar()
        {
            // Her bölüm için geçen test oranına göre puan hesapla
            int toplam1 = HesaplaOrtalamaGecen + HesaplaOrtalamaKalan;
            int toplam2 = BelirleHarfNotuGecen + BelirleHarfNotuKalan;
            int toplam3 = BelirleGecmeDurumuGecen + BelirleGecmeDurumuKalan;

            if (toplam1 > 0)
                HesaplaOrtalamaPuan = (double)HesaplaOrtalamaGecen / toplam1 * HESAPLA_ORTALAMA_MAX;
            
            if (toplam2 > 0)
                BelirleHarfNotuPuan = (double)BelirleHarfNotuGecen / toplam2 * BELIRLE_HARF_NOTU_MAX;
            
            if (toplam3 > 0)
                BelirleGecmeDurumuPuan = (double)BelirleGecmeDurumuGecen / toplam3 * BELIRLE_GECME_DURUMU_MAX;
        }

        static void Sonuclar()
        {
            double toplamPuan = HesaplaOrtalamaPuan + BelirleHarfNotuPuan + BelirleGecmeDurumuPuan;

            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║              📊 PUAN TABLOSU                     ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  HesaplaOrtalama    │ {HesaplaOrtalamaPuan,6:F2} / {HESAPLA_ORTALAMA_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  BelirleHarfNotu    │ {BelirleHarfNotuPuan,6:F2} / {BELIRLE_HARF_NOTU_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  BelirleGecmeDurumu │ {BelirleGecmeDurumuPuan,6:F2} / {BELIRLE_GECME_DURUMU_MAX,5:F2} puan    ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  TOPLAM PUAN        │ {toplamPuan,6:F2} / 25.00 puan    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");

            // Yüzde hesapla
            double yuzde = (toplamPuan / 25.0) * 100;
            Console.WriteLine($"\n📈 Başarı Yüzdesi: %{yuzde:F1}");

            if (yuzde >= 100)
                Console.WriteLine("\n🎉 TEBRİKLER! TÜM TESTLER BAŞARILI! FULL PUAN!");
            else if (yuzde >= 80)
                Console.WriteLine("\n✅ Çok iyi! Birkaç küçük düzeltmeyle full puan alabilirsiniz.");
            else if (yuzde >= 50)
                Console.WriteLine("\n⚠️ Orta seviye. Eksik kısımları gözden geçirin.");
            else
                Console.WriteLine("\n❌ Daha fazla çalışma gerekiyor. README'yi tekrar okuyun.");

            if (toplamPuan < 25)
                Environment.Exit(1);
        }
    }
}
