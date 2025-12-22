using System;

namespace CSharpHomework
{
    public class Problem1
    {
        // YANLIŞ: Formül yanlış (0.5 + 0.5 yerine 0.4 + 0.6 olmalı)
        public static double HesaplaOrtalama(int vize, int final)
        {
            return vize * 0.5 + final * 0.5; // HATA: Yanlış ağırlıklar
        }

        // YANLIŞ: Sadece birkaç durumu kapsıyor
        public static string BelirleHarfNotu(double ortalama, int final)
        {
            // Final < 50 kontrolü yok!
            if (ortalama >= 90) return "AA";
            if (ortalama >= 70) return "CC"; // Ara notlar atlanmış
            return "FF";
        }

        // YANLIŞ: Şartlı Geçti durumu yok
        public static string BelirleGecmeDurumu(string harfNotu)
        {
            if (harfNotu == "AA" || harfNotu == "BB")
                return "Geçti";
            return "Kaldı"; // DC, DD için "Şartlı Geçti" olmalıydı
        }
    }
}
