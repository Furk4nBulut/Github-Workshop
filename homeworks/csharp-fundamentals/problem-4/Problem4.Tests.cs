using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 4 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// 
    /// Puanlama:
    /// - DiziToplami: 4 puan
    /// - DiziOrtalamasi: 4 puan
    /// - EnBuyukBul: 4 puan
    /// - EnKucukBul: 4 puan
    /// - CiftSayilariFiltrele: 5 puan
    /// - SayiTekrarSay: 4 puan
    /// - TOPLAM: 25 puan
    /// </summary>
    public class Problem4Tests
    {
        // Sayaçlar
        public static int DiziToplamiGecen = 0, DiziToplamiKalan = 0;
        public static int DiziOrtalamasiGecen = 0, DiziOrtalamasiKalan = 0;
        public static int EnBuyukGecen = 0, EnBuyukKalan = 0;
        public static int EnKucukGecen = 0, EnKucukKalan = 0;
        public static int CiftFiltreleGecen = 0, CiftFiltreleKalan = 0;
        public static int TekrarSayGecen = 0, TekrarSayKalan = 0;

        // Puan ağırlıkları
        const double DIZI_TOPLAMI_MAX = 4.0;
        const double DIZI_ORTALAMASI_MAX = 4.0;
        const double EN_BUYUK_MAX = 4.0;
        const double EN_KUCUK_MAX = 4.0;
        const double CIFT_FILTRELE_MAX = 5.0;
        const double TEKRAR_SAY_MAX = 4.0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║         Problem 4 - Test Sistemi                 ║");
            Console.WriteLine("║         Dizi ve Liste İşlemleri                  ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine("║  Bölüm                    │ Max Puan             ║");
            Console.WriteLine("║  ─────────────────────────┼──────────────────────║");
            Console.WriteLine("║  DiziToplami              │ 4 puan               ║");
            Console.WriteLine("║  DiziOrtalamasi           │ 4 puan               ║");
            Console.WriteLine("║  EnBuyukBul               │ 4 puan               ║");
            Console.WriteLine("║  EnKucukBul               │ 4 puan               ║");
            Console.WriteLine("║  CiftSayilariFiltrele     │ 5 puan               ║");
            Console.WriteLine("║  SayiTekrarSay            │ 4 puan               ║");
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

            TestDiziToplami();
            TestDiziOrtalamasi();
            TestEnBuyukBul();
            TestEnKucukBul();
            TestCiftSayilariFiltrele();
            TestSayiTekrarSay();

            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem4_(\d+)\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem4_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestDiziToplami()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 1: DiziToplami (4 puan)                 │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int[] dizi, int beklenen, string aciklama)[] {
                (new int[] {1, 2, 3, 4, 5}, 15, "[1,2,3,4,5]"),
                (new int[] {}, 0, "boş dizi"),
                (new int[] {-1, -2, -3}, -6, "negatif sayılar"),
                (new int[] {100}, 100, "tek eleman")
            };

            foreach (var (dizi, beklenen, aciklama) in testler)
            {
                try
                {
                    int sonuc = Problem4.DiziToplami(dizi);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {aciklama} → {beklenen}");
                        DiziToplamiGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {aciklama} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        DiziToplamiKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {aciklama} → Hata: {ex.Message}");
                    DiziToplamiKalan++;
                }
            }

            int t = DiziToplamiGecen + DiziToplamiKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {DiziToplamiGecen}/{t} test geçti\n");
        }

        static void TestDiziOrtalamasi()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 2: DiziOrtalamasi (4 puan)              │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int[] dizi, double beklenen, string aciklama)[] {
                (new int[] {10, 20, 30}, 20.0, "[10,20,30]"),
                (new int[] {1, 2, 3, 4, 5}, 3.0, "[1,2,3,4,5]"),
                (new int[] {}, 0.0, "boş dizi")
            };

            foreach (var (dizi, beklenen, aciklama) in testler)
            {
                try
                {
                    double sonuc = Problem4.DiziOrtalamasi(dizi);
                    if (Math.Abs(sonuc - beklenen) < 0.01)
                    {
                        Console.WriteLine($"   ✅ {aciklama} → {beklenen}");
                        DiziOrtalamasiGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {aciklama} → Beklenen: {beklenen}, Bulunan: {sonuc:F2}");
                        DiziOrtalamasiKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {aciklama} → Hata: {ex.Message}");
                    DiziOrtalamasiKalan++;
                }
            }

            int t = DiziOrtalamasiGecen + DiziOrtalamasiKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {DiziOrtalamasiGecen}/{t} test geçti\n");
        }

        static void TestEnBuyukBul()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 3: EnBuyukBul (4 puan)                  │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int[] dizi, int beklenen, string aciklama)[] {
                (new int[] {3, 7, 2, 9, 1}, 9, "[3,7,2,9,1]"),
                (new int[] {-5, -2, -8}, -2, "negatif sayılar"),
                (new int[] {5, 5, 5}, 5, "aynı sayılar")
            };

            foreach (var (dizi, beklenen, aciklama) in testler)
            {
                try
                {
                    int sonuc = Problem4.EnBuyukBul(dizi);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {aciklama} → {beklenen}");
                        EnBuyukGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {aciklama} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        EnBuyukKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {aciklama} → Hata: {ex.Message}");
                    EnBuyukKalan++;
                }
            }

            int t = EnBuyukGecen + EnBuyukKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {EnBuyukGecen}/{t} test geçti\n");
        }

        static void TestEnKucukBul()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 4: EnKucukBul (4 puan)                  │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int[] dizi, int beklenen, string aciklama)[] {
                (new int[] {3, 7, 2, 9, 1}, 1, "[3,7,2,9,1]"),
                (new int[] {-5, -2, -8}, -8, "negatif sayılar"),
                (new int[] {5, 5, 5}, 5, "aynı sayılar")
            };

            foreach (var (dizi, beklenen, aciklama) in testler)
            {
                try
                {
                    int sonuc = Problem4.EnKucukBul(dizi);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {aciklama} → {beklenen}");
                        EnKucukGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {aciklama} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        EnKucukKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {aciklama} → Hata: {ex.Message}");
                    EnKucukKalan++;
                }
            }

            int t = EnKucukGecen + EnKucukKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {EnKucukGecen}/{t} test geçti\n");
        }

        static void TestCiftSayilariFiltrele()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 5: CiftSayilariFiltrele (5 puan)        │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            // Test 1
            try
            {
                var s1 = Problem4.CiftSayilariFiltrele(new int[] {1, 2, 3, 4, 5, 6});
                if (s1.Count == 3 && s1.Contains(2) && s1.Contains(4) && s1.Contains(6))
                {
                    Console.WriteLine($"   ✅ [1,2,3,4,5,6] → [2,4,6]");
                    CiftFiltreleGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ [1,2,3,4,5,6] → Beklenen: [2,4,6], Bulunan: [{string.Join(",", s1)}]");
                    CiftFiltreleKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ [1,2,3,4,5,6] → Hata: {ex.Message}");
                CiftFiltreleKalan++;
            }

            // Test 2
            try
            {
                var s2 = Problem4.CiftSayilariFiltrele(new int[] {1, 3, 5});
                if (s2.Count == 0)
                {
                    Console.WriteLine($"   ✅ [1,3,5] → boş liste");
                    CiftFiltreleGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ [1,3,5] → Beklenen: boş, Bulunan: {s2.Count} eleman");
                    CiftFiltreleKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ [1,3,5] → Hata: {ex.Message}");
                CiftFiltreleKalan++;
            }

            // Test 3
            try
            {
                var s3 = Problem4.CiftSayilariFiltrele(new int[] {2, 4, 6, 8});
                if (s3.Count == 4)
                {
                    Console.WriteLine($"   ✅ [2,4,6,8] → 4 eleman");
                    CiftFiltreleGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ [2,4,6,8] → Beklenen: 4 eleman, Bulunan: {s3.Count}");
                    CiftFiltreleKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ [2,4,6,8] → Hata: {ex.Message}");
                CiftFiltreleKalan++;
            }

            // Test 4
            try
            {
                var s4 = Problem4.CiftSayilariFiltrele(new int[] {});
                if (s4.Count == 0)
                {
                    Console.WriteLine($"   ✅ boş dizi → boş liste");
                    CiftFiltreleGecen++;
                }
                else
                {
                    Console.WriteLine($"   ❌ boş dizi → Beklenen: boş");
                    CiftFiltreleKalan++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ boş dizi → Hata: {ex.Message}");
                CiftFiltreleKalan++;
            }

            int t = CiftFiltreleGecen + CiftFiltreleKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {CiftFiltreleGecen}/{t} test geçti\n");
        }

        static void TestSayiTekrarSay()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 6: SayiTekrarSay (4 puan)               │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int[] dizi, int aranan, int beklenen, string aciklama)[] {
                (new int[] {1, 2, 3, 2, 4, 2}, 2, 3, "2 sayısı 3 kez"),
                (new int[] {1, 2, 3}, 5, 0, "5 sayısı yok"),
                (new int[] {5, 5, 5, 5}, 5, 4, "5 sayısı 4 kez"),
                (new int[] {}, 1, 0, "boş dizi")
            };

            foreach (var (dizi, aranan, beklenen, aciklama) in testler)
            {
                try
                {
                    int sonuc = Problem4.SayiTekrarSay(dizi, aranan);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {aciklama} → {beklenen}");
                        TekrarSayGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {aciklama} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        TekrarSayKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {aciklama} → Hata: {ex.Message}");
                    TekrarSayKalan++;
                }
            }

            int t = TekrarSayGecen + TekrarSayKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {TekrarSayGecen}/{t} test geçti\n");
        }

        static void Sonuclar()
        {
            int t1 = DiziToplamiGecen + DiziToplamiKalan;
            int t2 = DiziOrtalamasiGecen + DiziOrtalamasiKalan;
            int t3 = EnBuyukGecen + EnBuyukKalan;
            int t4 = EnKucukGecen + EnKucukKalan;
            int t5 = CiftFiltreleGecen + CiftFiltreleKalan;
            int t6 = TekrarSayGecen + TekrarSayKalan;

            double p1 = t1 > 0 ? (double)DiziToplamiGecen / t1 * DIZI_TOPLAMI_MAX : 0;
            double p2 = t2 > 0 ? (double)DiziOrtalamasiGecen / t2 * DIZI_ORTALAMASI_MAX : 0;
            double p3 = t3 > 0 ? (double)EnBuyukGecen / t3 * EN_BUYUK_MAX : 0;
            double p4 = t4 > 0 ? (double)EnKucukGecen / t4 * EN_KUCUK_MAX : 0;
            double p5 = t5 > 0 ? (double)CiftFiltreleGecen / t5 * CIFT_FILTRELE_MAX : 0;
            double p6 = t6 > 0 ? (double)TekrarSayGecen / t6 * TEKRAR_SAY_MAX : 0;
            double toplam = p1 + p2 + p3 + p4 + p5 + p6;

            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║              📊 PUAN TABLOSU                     ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  DiziToplami          │ {p1,6:F2} / {DIZI_TOPLAMI_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  DiziOrtalamasi       │ {p2,6:F2} / {DIZI_ORTALAMASI_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  EnBuyukBul           │ {p3,6:F2} / {EN_BUYUK_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  EnKucukBul           │ {p4,6:F2} / {EN_KUCUK_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  CiftSayilariFiltrele │ {p5,6:F2} / {CIFT_FILTRELE_MAX,5:F2} puan    ║");
            Console.WriteLine($"║  SayiTekrarSay        │ {p6,6:F2} / {TEKRAR_SAY_MAX,5:F2} puan    ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  TOPLAM PUAN          │ {toplam,6:F2} / 25.00 puan    ║");
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
