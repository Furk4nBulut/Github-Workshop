# 🎯 C# Temel Programlama Ödevleri

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Final](https://img.shields.io/badge/Final-100%20Puan-red?style=for-the-badge)](.)

## 📋 Genel Bilgiler

| Bilgi | Değer |
|-------|-------|
| **Toplam Puan** | 100 puan |
| **Problem Sayısı** | 4 adet |
| **Her Problem** | 25 puan |
| **Teslim Şekli** | Pull Request |

---

## 🎯 Kapsanan Konular

| Konu | Açıklama |
|------|----------|
| `if-else` | Koşullu ifadeler |
| `switch-case` | Çoklu seçim yapısı |
| `for` | Belirli sayıda tekrar eden döngü |
| `while` | Koşullu döngü |
| `foreach` | Koleksiyon üzerinde döngü |
| `do-while` | En az bir kez çalışan döngü |
| Fonksiyonlar | Metot tanımlama ve çağırma |
| Ternary Operatör | `? :` ile kısa koşul |
| Mantıksal Operatörler | `&&`, `\|\|`, `!` |

---

## 📝 Problemler

| # | Problem | Konu | Puan |
|---|---------|------|------|
| 1 | [Problem 1](problem-1/) | if-else, Mantıksal Operatörler | 25 |
| 2 | [Problem 2](problem-2/) | switch-case, Ternary Operatör | 25 |
| 3 | [Problem 3](problem-3/) | for, while, do-while | 25 |
| 4 | [Problem 4](problem-4/) | foreach, Fonksiyonlar | 25 |
| | **TOPLAM** | | **100** |

---

## 📤 Nasıl Teslim Edilir?

### Adım 1: Fork & Clone
```bash
# Repoyu fork edin
git clone https://github.com/KULLANICI_ADINIZ/Github-Workshop.git
cd Github-Workshop
```

### Adım 2: Branch Oluşturun
```bash
git checkout -b homework/OGRENCI_NO
# Örnek: git checkout -b homework/210316011
```

### Adım 3: Çözümlerinizi Yazın

Her problem klasöründe:
1. `submissions/` alt klasörüne gidin
2. Çözüm dosyanızı oluşturun: `ProblemX_OGRENCI_NO.cs`

**Dosya Adı Formatı:**
```
Problem1_210316011.cs
Problem2_210316011.cs
Problem3_210316011.cs
Problem4_210316011.cs
```

### Adım 4: Commit & Push
```bash
git add .
git commit -m "feat: C# ödev çözümleri - OGRENCI_NO"
git push origin homework/OGRENCI_NO
```

### Adım 5: Pull Request Açın
1. GitHub'da fork'unuza gidin
2. "Compare & pull request" tıklayın
3. **Önemli:** PR şablonu açılacak, formu doldurun
4. PR başlığı: `Ödev: C# Çözümleri - OGRENCI_NO - AD SOYAD`

> [!IMPORTANT]
> PR açtığınızda **akademik dürüstlük beyanını** onaylamanız gerekiyor!
> 
> Beyan içeriği:
> - ✅ Bu ödevi kendim yaptım, kopya çekmedim
> - ✅ Kodlarımı test ettim ve çalıştığını onaylıyorum
> - ✅ Dosya adı formatına uydum
> - ✅ Başkasının dosyasını değiştirmedim

> [!NOTE]
> PR açtığınızda **GitHub Actions otomatik testler** çalışacak!  
> Testler başarısız olursa PR birleştirilmez.

---

## 📁 Klasör Yapısı

```
homeworks/csharp-fundamentals/
├── README.md                    # Bu dosya
│
├── problem-1/                   # Problem 1 (25 puan)
│   ├── README.md                # Problem açıklaması
│   ├── Problem1.Tests.cs        # Test dosyası
│   └── submissions/             # Çözümler buraya
│       └── Problem1_OGRENCI_NO.cs
│
├── problem-2/                   # Problem 2 (25 puan)
│   ├── README.md
│   ├── Problem2.Tests.cs
│   └── submissions/
│
├── problem-3/                   # Problem 3 (25 puan)
│   ├── README.md
│   ├── Problem3.Tests.cs
│   └── submissions/
│
└── problem-4/                   # Problem 4 (25 puan)
    ├── README.md
    ├── Problem4.Tests.cs
    └── submissions/
```

---

## ⚠️ Önemli Kurallar

> [!WARNING]
> - ❌ Test dosyalarını (`*.Tests.cs`) **DEĞİŞTİRMEYİN**
> - ❌ README dosyalarını **DEĞİŞTİRMEYİN**
> - ❌ Başkasının çözümünü **KOPYALAMAYIN**
> - ✅ Sadece `submissions/` klasörüne çözüm ekleyin
> - ✅ Dosya adı formatı: `ProblemX_OGRENCI_NO.cs`
> - ✅ Öğrenci numarası **9 haneli** olmalı

---

## 🧪 Test Sistemi

Her problem için test dosyası bulunmaktadır. PR açtığınızda:

1. ✅ GitHub Actions tetiklenir
2. ✅ Dosya adı formatı kontrol edilir
3. ✅ Çözümünüz derlenir
4. ✅ Testler çalıştırılır
5. ✅ Sonuçlar PR'da gösterilir

### Puanlama

| Durum | Sonuç |
|-------|-------|
| Tüm testler geçti | ✅ Tam puan |
| Bazı testler başarısız | ⚠️ Orantılı puan |
| Derleme hatası | ❌ 0 puan |
| Dosya adı yanlış | ❌ 0 puan |

---

## 💡 İpuçları

1. Her problemi **dikkatli okuyun**
2. README'deki **şablonu** kullanın
3. Kodunuzu **yerel olarak test edin**
4. `using` ifadelerini unutmayın
5. Dosya adı formatına dikkat edin

---

## 🆘 Yardım

- 💬 [GitHub Discussions](https://github.com/Furk4nBulut/Github-Workshop/discussions)
- 🐛 [Issues](https://github.com/Furk4nBulut/Github-Workshop/issues)
- 📖 [Wiki](https://github.com/Furk4nBulut/Github-Workshop/wiki)

---

**Son Teslim Tarihi:** _Eğitmen tarafından belirlenecek_

**Başarılar! 🚀**
