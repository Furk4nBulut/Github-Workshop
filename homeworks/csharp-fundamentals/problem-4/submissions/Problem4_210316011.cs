using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem4
    {
        // YANLIŞ: Boş dizi kontrolü yok
        public static int DiziToplami(int[] dizi)
        {
            int toplam = 0;
            foreach (var sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam; // Bu aslında doğru, ama diğerleri yanlış
        }

        // YANLIŞ: Boş dizi için exception fırlatır
        public static double DiziOrtalamasi(int[] dizi)
        {
            // HATA: dizi.Length == 0 kontrolü yok
            int toplam = 0;
            foreach (var sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam / dizi.Length; // DivideByZero hatası verir
        }

        // YANLIŞ: int.MinValue ile başlamıyor
        public static int EnBuyukBul(int[] dizi)
        {
            int max = 0; // HATA: int.MinValue olmalı
            foreach (var sayi in dizi)
            {
                if (sayi > max) max = sayi;
            }
            return max; // Negatif dizilerde yanlış sonuç
        }

        // YANLIŞ: int.MaxValue ile başlamıyor  
        public static int EnKucukBul(int[] dizi)
        {
            int min = 0; // HATA: int.MaxValue olmalı
            foreach (var sayi in dizi)
            {
                if (sayi < min) min = sayi;
            }
            return min; // Pozitif dizilerde yanlış sonuç
        }

        // YANLIŞ: Tek sayıları filtreliyor
        public static List<int> CiftSayilariFiltrele(int[] dizi)
        {
            List<int> sonuc = new List<int>();
            foreach (var sayi in dizi)
            {
                if (sayi % 2 != 0) // HATA: == 0 olmalı (çiftler için)
                    sonuc.Add(sayi);
            }
            return sonuc;
        }

        // YANLIŞ: Her zaman 0 döndürüyor
        public static int SayiTekrarSay(int[] dizi, int aranan)
        {
            return 0; // HATA: Hiç saymıyor!
        }
    }
}
