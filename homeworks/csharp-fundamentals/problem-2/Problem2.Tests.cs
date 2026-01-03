using System;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 2 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// 
    /// Puanlama:
    /// - GunAdiGetir: 7 puan
    /// - ArtikYilMi: 6 puan
    /// - AyinGunSayisi: 7 puan
    /// - HaftaIciSonuMu: 5 puan
    /// - TOPLAM: 25 puan
    /// </summary>
    public class Problem2Tests
    {
        // Her bölüm için sayaçlar
        public static int GunAdiGetirGecen = 0, GunAdiGetirKalan = 0;
        public static int ArtikYilMiGecen = 0, ArtikYilMiKalan = 0;
        public static int AyinGunSayisiGecen = 0, AyinGunSayisiKalan = 0;
        public static int HaftaIciSonuMuGecen = 0, HaftaIciSonuMuKalan = 0;

        // Puan ağırlıkları
        const double GUN_ADI_MAX = 7.0;
        const double ARTIK_YIL_MAX = 6.0;
        const double AYIN_GUN_MAX = 7.0;
        const double HAFTA_ICI_MAX = 5.0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║         Problem 2 - Test Sistemi                 ║");
            Console.WriteLine("║         Gün ve Ay Hesaplama                      ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine("║  Bölüm                    │ Max Puan             ║");
            Console.WriteLine("║  ─────────────────────────┼──────────────────────║");
            Console.WriteLine("║  GunAdiGetir              │ 7 puan               ║");
            Console.WriteLine("║  ArtikYilMi               │ 6 puan               ║");
            Console.WriteLine("║  AyinGunSayisi            │ 7 puan               ║");
            Console.WriteLine("║  HaftaIciSonuMu           │ 5 puan               ║");
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

            TestGunAdiGetir();
            TestArtikYilMi();
            TestAyinGunSayisi();
            TestHaftaIciSonuMu();

            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem2_(\d+)\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem2_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestGunAdiGetir()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 1: GunAdiGetir (7 puan)                 │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int gun, string beklenen)[] {
                (1, "Pazartesi"), (2, "Salı"), (3, "Çarşamba"), (4, "Perşembe"),
                (5, "Cuma"), (6, "Cumartesi"), (7, "Pazar"), (0, "Geçersiz gün"), (8, "Geçersiz gün")
            };

            foreach (var (gun, beklenen) in testler)
            {
                try
                {
                    string sonuc = Problem2.GunAdiGetir(gun);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {gun} → {beklenen}");
                        GunAdiGetirGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {gun} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        GunAdiGetirKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {gun} → Hata: {ex.Message}");
                    GunAdiGetirKalan++;
                }
            }

            int toplam = GunAdiGetirGecen + GunAdiGetirKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {GunAdiGetirGecen}/{toplam} test geçti\n");
        }

        static void TestArtikYilMi()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 2: ArtikYilMi (6 puan)                  │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int yil, bool beklenen, string aciklama)[] {
                (2024, true, "4'e bölünür"),
                (2023, false, "4'e bölünmez"),
                (2000, true, "400'e bölünür"),
                (1900, false, "100'e bölünür ama 400'e bölünmez"),
                (2100, false, "100'e bölünür ama 400'e bölünmez"),
                (2020, true, "4'e bölünür")
            };

            foreach (var (yil, beklenen, aciklama) in testler)
            {
                try
                {
                    bool sonuc = Problem2.ArtikYilMi(yil);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ {yil} → {beklenen} ({aciklama})");
                        ArtikYilMiGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ {yil} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        ArtikYilMiKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ {yil} → Hata: {ex.Message}");
                    ArtikYilMiKalan++;
                }
            }

            int toplam = ArtikYilMiGecen + ArtikYilMiKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {ArtikYilMiGecen}/{toplam} test geçti\n");
        }

        static void TestAyinGunSayisi()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 3: AyinGunSayisi (7 puan)               │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int ay, int yil, int beklenen, string aciklama)[] {
                (1, 2024, 31, "Ocak"),
                (2, 2024, 29, "Şubat artık yıl"),
                (2, 2023, 28, "Şubat normal yıl"),
                (4, 2024, 30, "Nisan"),
                (7, 2024, 31, "Temmuz"),
                (12, 2024, 31, "Aralık"),
                (0, 2024, 0, "Geçersiz ay")
            };

            foreach (var (ay, yil, beklenen, aciklama) in testler)
            {
                try
                {
                    int sonuc = Problem2.AyinGunSayisi(ay, yil);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ ay={ay}, yıl={yil} → {beklenen} ({aciklama})");
                        AyinGunSayisiGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ ay={ay}, yıl={yil} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        AyinGunSayisiKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ ay={ay}, yıl={yil} → Hata: {ex.Message}");
                    AyinGunSayisiKalan++;
                }
            }

            int toplam = AyinGunSayisiGecen + AyinGunSayisiKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {AyinGunSayisiGecen}/{toplam} test geçti\n");
        }

        static void TestHaftaIciSonuMu()
        {
            Console.WriteLine("┌──────────────────────────────────────────────────┐");
            Console.WriteLine("│ 📊 BÖLÜM 4: HaftaIciSonuMu (5 puan)              │");
            Console.WriteLine("└──────────────────────────────────────────────────┘");

            var testler = new (int gun, string beklenen)[] {
                (1, "Hafta İçi"), (3, "Hafta İçi"), (5, "Hafta İçi"),
                (6, "Hafta Sonu"), (7, "Hafta Sonu")
            };

            foreach (var (gun, beklenen) in testler)
            {
                try
                {
                    string sonuc = Problem2.HaftaIciSonuMu(gun);
                    if (sonuc == beklenen)
                    {
                        Console.WriteLine($"   ✅ gün={gun} → {beklenen}");
                        HaftaIciSonuMuGecen++;
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ gün={gun} → Beklenen: {beklenen}, Bulunan: {sonuc}");
                        HaftaIciSonuMuKalan++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ gün={gun} → Hata: {ex.Message}");
                    HaftaIciSonuMuKalan++;
                }
            }

            int toplam = HaftaIciSonuMuGecen + HaftaIciSonuMuKalan;
            Console.WriteLine($"   ─────────────────────────────────────────");
            Console.WriteLine($"   Sonuç: {HaftaIciSonuMuGecen}/{toplam} test geçti\n");
        }

        static void Sonuclar()
        {
            // Puanları hesapla
            int t1 = GunAdiGetirGecen + GunAdiGetirKalan;
            int t2 = ArtikYilMiGecen + ArtikYilMiKalan;
            int t3 = AyinGunSayisiGecen + AyinGunSayisiKalan;
            int t4 = HaftaIciSonuMuGecen + HaftaIciSonuMuKalan;

            double p1 = t1 > 0 ? (double)GunAdiGetirGecen / t1 * GUN_ADI_MAX : 0;
            double p2 = t2 > 0 ? (double)ArtikYilMiGecen / t2 * ARTIK_YIL_MAX : 0;
            double p3 = t3 > 0 ? (double)AyinGunSayisiGecen / t3 * AYIN_GUN_MAX : 0;
            double p4 = t4 > 0 ? (double)HaftaIciSonuMuGecen / t4 * HAFTA_ICI_MAX : 0;
            double toplam = p1 + p2 + p3 + p4;

            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║              📊 PUAN TABLOSU                     ║");
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║  GunAdiGetir      │ {p1,6:F2} / {GUN_ADI_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  ArtikYilMi       │ {p2,6:F2} / {ARTIK_YIL_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  AyinGunSayisi    │ {p3,6:F2} / {AYIN_GUN_MAX,5:F2} puan        ║");
            Console.WriteLine($"║  HaftaIciSonuMu   │ {p4,6:F2} / {HAFTA_ICI_MAX,5:F2} puan        ║");
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
