<div align="center">
k
<!-- LOGO & HEADER -->
<img src="https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png" alt="GitHub Logo" width="120"/>

# 🎓 GitHub Workshop
## Sıfırdan Profesyonelliğe Kapsamlı GitHub Eğitimi

[![GitHub Workshop](https://img.shields.io/badge/GitHub-Workshop-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Furk4nBulut/Github-Workshop)
[![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)](LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-Welcome-brightgreen?style=for-the-badge)](https://github.com/Furk4nBulut/Github-Workshop/pulls)
[![Wiki](https://img.shields.io/badge/📚-Wiki-blue?style=for-the-badge)](https://github.com/Furk4nBulut/Github-Workshop/wiki)
[![GitHub Pages](https://img.shields.io/badge/🌐-Canlı_Demo-6366f1?style=for-the-badge)](https://furk4nbulut.github.io/Github-Workshop/)

**Bilgisayar Programcılığı ve Yazılım Mühendisliği Öğrencileri İçin**

*Git ve GitHub'ı sıfırdan öğrenin, profesyonel seviyeye ulaşın!*

[🌐 Canlı Demo](https://furk4nbulut.github.io/Github-Workshop/) · 
[📖 Wiki'ye Git](https://github.com/Furk4nBulut/Github-Workshop/wiki) · 
[🚀 Hızlı Başlangıç](#-hızlı-başlangıç) · 
[📚 Müfredat](#-müfredat) · 
[🤝 Katkıda Bulun](#-katkıda-bulunma)

---

### 🌟 Bu Eğitim Neden Farklı?

| | |
|:---:|:---:|
| 🎯 **Pratik Odaklı** | 📚 **Kapsamlı Dokümantasyon** |
| Her modülde uygulamalı alıştırmalar | Wiki'de detaylı Türkçe içerik |
| 🏢 **Endüstri Standartları** | 🆓 **Tamamen Ücretsiz** |
| Gerçek iş ortamı pratikleri | Açık kaynak eğitim materyalleri |

</div>

---

## 📌 İçindekiler

- [🎯 Eğitim Hakkında](#-eğitim-hakkında)
- [📋 Yoklama](#-yoklama)
- [🚀 Hızlı Başlangıç](#-hızlı-başlangıç)
- [📚 Müfredat](#-müfredat)
- [📊 Eğitim İstatistikleri](#-eğitim-istatistikleri)
- [🎓 Kazanımlar](#-kazanımlar)
- [🛠️ Ön Gereksinimler](#️-ön-gereksinimler)
- [📁 Repo Yapısı](#-repo-yapısı)
- [📝 Pratik Alıştırmalar](#-pratik-alıştırmalar)
- [📋 Cheat Sheets](#-cheat-sheets)
- [🔗 Faydalı Kaynaklar](#-faydalı-kaynaklar)
- [🤝 Katkıda Bulunma](#-katkıda-bulunma)
- [📞 İletişim](#-iletişim)
- [📄 Lisans](#-lisans)

---

## 🎯 Eğitim Hakkında

Bu workshop, **Git** ve **GitHub**'ı hiç bilmeyenlerden başlayarak, profesyonel yazılım geliştirme ekiplerinin kullandığı iş akışlarına kadar kapsamlı bir eğitim sunar.

### 🤔 Kim İçin?

- 💻 Yazılım geliştirmeye yeni başlayanlar
- 🎓 Bilgisayar Mühendisliği / Programcılığı öğrencileri
- 👩‍💼 Kariyer değiştirmek isteyen profesyoneller
- 🌱 Git'i daha iyi öğrenmek isteyen herkes

### ✨ Neler Öğreneceksiniz?

```
✅ Git'in temel mantığını ve komutlarını
✅ GitHub platformunu etkin kullanmayı
✅ Profesyonel commit mesajları yazmayı (Conventional Commits)
✅ Branch stratejileri ve iş akışlarını
✅ Takım çalışması araçlarını (PR, Issues, Projects)
✅ CI/CD temelleri ve GitHub Actions
✅ Portfolyo oluşturma ve kariyer gelişimi
```

---

## 📋 Yoklama

> **Workshop'a katılım için aşağıdaki adımları takip edin!**

### 📝 Yoklama Nasıl Alınır?

1. 🍴 Bu repoyu **fork** edin
2. 📁 `attendance/` klasörüne gidin
3. 📄 Yeni bir dosya oluşturun: `ogrenci_no.txt` (örn: `210316011.txt`)
4. 📝 Dosya içine **sadece** e-posta adresinizi yazın: `210316011@ogr.cbu.edu.tr`
5. 🔀 **Pull Request** açın

### ⚠️ Önemli Kurallar

- ✅ Sadece **kendi dosyanızı** oluşturun.
- ❌ Başkasının dosyasını **silmeyin** veya **değiştirmeyin**.
- 🤖 GitHub Actions otomatik olarak dosya isminizi ve formatınızı kontrol edecektir.

> [!TIP]
> [📁 Yoklama Klasörü](attendance/) içindeki dosyaları inceleyebilirsiniz.

---

## �🚀 Hızlı Başlangıç

### Adım 1: Git Kurulumu

```bash
# Git versiyonunu kontrol edin
git --version

# Kurulu değilse:
# Windows: https://git-scm.com/download/win
# Mac: brew install git
# Linux: sudo apt install git
```

### Adım 2: İlk Yapılandırma

```bash
# Kimlik bilgilerinizi ayarlayın
git config --global user.name "Adınız Soyadınız"
git config --global user.email "email@example.com"

# Ayarları kontrol edin
git config --list
```

### Adım 3: GitHub Hesabı

1. 🌐 [github.com](https://github.com) adresine gidin
2. 📝 "Sign up" ile ücretsiz hesap oluşturun
3. 📧 E-postanızı doğrulayın
4. 🎒 [Student Developer Pack](https://education.github.com/pack)'e başvurun (öğrenciyseniz)

### Adım 4: İlk Repo

```bash
# Yeni klasör oluşturun
mkdir ilk-projem
cd ilk-projem

# Git başlatın
git init

# README dosyası oluşturun
echo "# İlk Projem" > README.md

# Değişiklikleri kaydedin
git add .
git commit -m "feat: ilk commit"

# GitHub'a bağlayın ve gönderin
git remote add origin https://github.com/KULLANICI/ilk-projem.git
git push -u origin main
```

### 🎉 Tebrikler! İlk GitHub repo'nuzu oluşturdunuz!

---

## 📚 Müfredat

<table>
<tr>
<td width="50%">

### 🚀 Modül 1: Giriş ve Motivasyon
> *"GitHub, kodlarınızın sosyal medyası ve güvenli kasasıdır."*

**[📖 Wiki'de Oku →](https://github.com/Furk4nBulut/Github-Workshop/wiki/Giriş-Ve-Motivasyon)**

- Git ve GitHub nedir?
- Versiyon kontrol sistemi mantığı
- GitHub Student Developer Pack
- GUI araçları (GitKraken, GitHub Desktop)

**⏱️ Süre:** ~1 saat

</td>
<td width="50%">

### 🛠️ Modül 2: Temel Teknik Beceriler
> *"Bu 5-6 temel komut, yazılım hayatınızın %90'ını oluşturacak."*

**[📖 Wiki'de Oku →](https://github.com/Furk4nBulut/Github-Workshop/wiki/Temel-Teknik-Beceriler)**

- Git temel komutları (init, add, commit, push, pull)
- Markdown yazımı ve README oluşturma
- Lisans türleri ve seçimi

**⏱️ Süre:** ~1.5 saat

</td>
</tr>
<tr>
<td width="50%">

### 🔄 Modül 3: Profesyonel İş Akışı
> *"Asla ana kod üzerinde deneme yapmayın."*

**[📖 Wiki'de Oku →](https://github.com/Furk4nBulut/Github-Workshop/wiki/Profesyonel-Is-Akisi)**

- Branch stratejileri (Git Flow, GitHub Flow)
- Fork ve Clone arasındaki fark
- Conventional Commits standartları
- Açık kaynak projelere katkı

**⏱️ Süre:** ~1.5 saat

</td>
<td width="50%">

### 👥 Modül 4: Takım Çalışması
> *"Yazılım bir ekip işidir."*

**[📖 Wiki'de Oku →](https://github.com/Furk4nBulut/Github-Workshop/wiki/Takim-Calismasi)**

- GitHub Organization oluşturma
- Pull Request süreci ve Code Review
- Issues ile proje takibi
- Projects (Kanban) ile görev yönetimi
- Discussions ile topluluk yönetimi

**⏱️ Süre:** ~1.5 saat

</td>
</tr>
<tr>
<td width="50%">

### ⚡ Modül 5: İleri Seviye
> *"Hata yaptığınızda projeyi silip baştan başlamayın."*

**[📖 Wiki'de Oku →](https://github.com/Furk4nBulut/Github-Workshop/wiki/Ileri-Seviye)**

- Git ileri komutları (rebase, stash, cherry-pick)
- Reset vs Revert, Reflog
- Git Tags ve Semantic Versioning
- GitHub Webhooks
- GitHub Actions (CI/CD temelleri)

**⏱️ Süre:** ~2 saat

</td>
<td width="50%">

### 🌟 Modül 6: Vitrin ve Kariyer
> *"GitHub profiliniz sizin yaşayan CV'nizdir."*

**[📖 Wiki'de Oku →](https://github.com/Furk4nBulut/Github-Workshop/wiki/Vitrin-Ve-Kariyer)**

- GitHub Profile README oluşturma
- İstatistik widget'ları ve badge'ler
- GitHub Pages ile portfolyo sitesi
- Özel domain bağlama
- Profesyonel portfolyo ipuçları

**⏱️ Süre:** ~1.5 saat

</td>
</tr>
</table>

---

## 📊 Eğitim İstatistikleri

<div align="center">

| 📚 Modül | ⏱️ Toplam Süre | 📝 Konu | 🎯 Seviye |
|:--------:|:-------------:|:-------:|:---------:|
| 6 | ~9 saat | 25+ | Başlangıç → İleri |

</div>

### 📈 Öğrenme Yolu

```
🌱 Başlangıç (Modül 1-2)
   │
   ├── Git ve GitHub temelleri
   ├── Temel komutlar
   └── Markdown ve README
   
⚙️ Orta Seviye (Modül 3-4)
   │
   ├── Branch stratejileri
   ├── Takım çalışması
   └── PR ve Code Review
   
🚀 İleri Seviye (Modül 5-6)
   │
   ├── İleri Git komutları
   ├── GitHub Actions
   └── Portfolyo ve kariyer
```

---

## 🎓 Kazanımlar

Bu eğitimi tamamladığınızda:

| Kazanım | Açıklama |
|:--------|:---------|
| ✅ **Git Hakimiyeti** | Temel ve ileri Git komutlarını ezberlemek yerine mantığını kavrayacaksınız |
| ✅ **Profesyonel Workflow** | Endüstri standartlarında iş akışı kullanabileceksiniz |
| ✅ **Takım Çalışması** | PR, Issues, Projects ile takım projelerinde çalışabileceksiniz |
| ✅ **CI/CD Temelleri** | GitHub Actions ile temel otomasyon kurabileceksiniz |
| ✅ **Portfolyo** | GitHub profilinizi profesyonel bir vitrine dönüştüreceksiniz |
| ✅ **Açık Kaynak Katkı** | Open source projelere katkıda bulunabileceksiniz |

---

## 🛠️ Ön Gereksinimler

### Zorunlu
- 💻 Bilgisayar (Windows, Mac veya Linux)
- 🌐 İnternet bağlantısı
- 📧 E-posta adresi

### Önerilen
- 📝 Temel programlama bilgisi (herhangi bir dil)
- 🖥️ Terminal/Komut satırı kullanımına aşinalık
- 🇬🇧 Temel İngilizce

### Kullanılacak Araçlar

| Araç | Amaç | Link |
|:-----|:-----|:-----|
| **Git** | Versiyon kontrol | [git-scm.com](https://git-scm.com) |
| **VS Code** | Kod editörü | [code.visualstudio.com](https://code.visualstudio.com) |
| **GitHub Desktop** | Git GUI (isteğe bağlı) | [desktop.github.com](https://desktop.github.com) |
| **GitKraken** | Git GUI (isteğe bağlı) | [gitkraken.com](https://www.gitkraken.com) |

---

## 📁 Repo Yapısı

```
Github-Workshop/
│
├── 📄 README.md                 # Bu dosya - Ana dokümantasyon
├── 📄 LICENSE                   # MIT Lisansı
├── 📄 CONTRIBUTING.md           # Katkıda bulunma rehberi
├── 📄 CODE_OF_CONDUCT.md        # Davranış kuralları
│
├── 📁 docs/                     # Ek dokümantasyon
│   ├── CURRICULUM.md            # Detaylı müfredat
│   ├── QUICK-START.md           # Hızlı başlangıç rehberi
│   └── FAQ.md                   # Sık sorulan sorular
│
├── 📁 exercises/                # Pratik alıştırmalar
│   ├── lab-01-first-repo/       # Lab 1: İlk Repo
│   ├── lab-02-branching/        # Lab 2: Branch Yönetimi
│   ├── lab-03-collaboration/    # Lab 3: İşbirliği
│   ├── lab-04-team-work/        # Lab 4: Takım Çalışması
│   ├── lab-05-automation/       # Lab 5: Otomasyon
│   └── lab-06-portfolio/        # Lab 6: Portfolyo
│
├── 📁 templates/                # Hazır şablonlar
│   ├── readme-templates/        # README şablonları
│   ├── profile-readme/          # Profil README şablonları
│   ├── github-templates/        # Issue/PR şablonları
│   └── github-actions/          # Actions workflow'ları
│
├── 📁 cheatsheets/              # Hızlı referans kartları
│   ├── git-commands.md          # Git komutları
│   ├── markdown-syntax.md       # Markdown söz dizimi
│   └── conventional-commits.md  # Commit standartları
│
└── 📁 assets/                   # Görseller ve kaynaklar
    ├── diagrams/                # Diyagramlar
    └── screenshots/             # Ekran görüntüleri
```

---

## 📝 Pratik Alıştırmalar

Her modül için uygulamalı lab alıştırmaları:

### 🧪 Lab 1: İlk Repository
**Hedef:** Sıfırdan bir GitHub reposu oluşturmak

```bash
# Adımlar:
1. Yeni klasör oluştur
2. git init ile başlat
3. README.md ekle
4. İlk commit yap
5. GitHub'da repo oluştur
6. Push yap
```

### 🧪 Lab 2: Branch Yönetimi
**Hedef:** Feature branch oluşturup merge etmek

```bash
# Adımlar:
1. Feature branch oluştur
2. Değişiklik yap ve commit et
3. Main'e geri dön
4. Merge yap
5. Conflict çöz (simülasyon)
```

### 🧪 Lab 3: Fork & Pull Request
**Hedef:** Açık kaynak projeye katkıda bulunmak

```bash
# Adımlar:
1. Bu repoyu fork edin
2. Clone yapın
3. Feature branch oluşturun
4. CONTRIBUTORS.md'ye isminizi ekleyin
5. PR açın
```

### 🧪 Lab 4: Takım Projesi Simülasyonu
**Hedef:** GitHub araçlarıyla takım çalışması yapmak

```bash
# Adımlar:
1. Organization oluştur
2. Takım üyelerini davet et
3. Project board oluştur
4. Issue aç ve assign et
5. PR ile code review yap
```

### 🧪 Lab 5: GitHub Actions
**Hedef:** Basit bir CI pipeline oluşturmak

```yaml
# Hedef workflow
- Push'ta otomatik test çalıştır
- PR'da lint kontrolü yap
- Badge ekle
```

### 🧪 Lab 6: Profesyonel Portfolyo
**Hedef:** GitHub profilini optimize etmek

```bash
# Adımlar:
1. Profile README oluştur
2. İstatistik widget'ları ekle
3. En iyi repo'ları pinle
4. GitHub Pages ile site yayınla
```

---

## 📋 Cheat Sheets

### ⚡ Temel Git Komutları

```bash
# Yapılandırma
git config --global user.name "Ad"
git config --global user.email "email"

# Repo işlemleri
git init                        # Yeni repo başlat
git clone <url>                 # Repo klonla

# Günlük kullanım
git status                      # Durumu gör
git add .                       # Tüm değişiklikleri ekle
git commit -m "mesaj"           # Commit yap
git push                        # Uzak repoya gönder
git pull                        # Uzak repodan çek

# Branch işlemleri
git branch                      # Branch'ları listele
git checkout -b <isim>          # Yeni branch oluştur ve geç
git merge <branch>              # Branch birleştir

# Geçmiş
git log --oneline               # Kısa commit geçmişi
git diff                        # Değişiklikleri gör
```

### 📝 Conventional Commits

```bash
feat:     Yeni özellik
fix:      Hata düzeltme
docs:     Dokümantasyon
style:    Kod formatı (mantık değişmez)
refactor: Kod yeniden düzenleme
test:     Test ekleme
chore:    Bakım işleri

# Örnekler
git commit -m "feat: kullanıcı login sayfası eklendi"
git commit -m "fix: navbar overflow sorunu düzeltildi"
git commit -m "docs: README kurulum adımları güncellendi"
```

### ⌨️ Markdown Hızlı Referans

```markdown
# Başlık 1
## Başlık 2
### Başlık 3

**Kalın** ve *italik* ve ~~üstü çizili~~

- Madde 1
- Madde 2
  - Alt madde

1. Sıralı 1
2. Sıralı 2

[Link](https://example.com)
![Resim](image.png)

`kod` ve ```kod bloğu```

> Alıntı

| Tablo | Başlık |
|-------|--------|
| Veri  | Veri   |
```

---

## 🔗 Faydalı Kaynaklar

### 📚 Resmi Dokümantasyon
| Kaynak | Link |
|:-------|:-----|
| GitHub Docs | [docs.github.com](https://docs.github.com) |
| Git Book (Türkçe) | [git-scm.com/book/tr](https://git-scm.com/book/tr) |
| GitHub Skills | [skills.github.com](https://skills.github.com) |
| Git Cheat Sheet | [education.github.com/git-cheat-sheet](https://education.github.com/git-cheat-sheet-education.pdf) |

### 🎓 Öğrenme Platformları
| Platform | Link |
|:---------|:-----|
| GitHub Learning Lab | [lab.github.com](https://lab.github.com) |
| Codecademy Git | [codecademy.com/learn/learn-git](https://www.codecademy.com/learn/learn-git) |
| Atlassian Git Tutorials | [atlassian.com/git/tutorials](https://www.atlassian.com/git/tutorials) |

### 🛠️ Araçlar
| Araç | Açıklama | Link |
|:-----|:---------|:-----|
| Oh My Git! | İnteraktif Git öğrenme oyunu | [ohmygit.org](https://ohmygit.org) |
| Learn Git Branching | Görsel branch öğrenme | [learngitbranching.js.org](https://learngitbranching.js.org) |
| Conventional Commits | Commit standartları | [conventionalcommits.org](https://www.conventionalcommits.org) |
| Shields.io | Badge oluşturma | [shields.io](https://shields.io) |
| GitHub Readme Stats | Profil istatistikleri | [github.com/anuraghazra/github-readme-stats](https://github.com/anuraghazra/github-readme-stats) |

### 🎨 İlham Kaynakları
| Kaynak | Link |
|:-------|:-----|
| Awesome READMEs | [github.com/matiassingers/awesome-readme](https://github.com/matiassingers/awesome-readme) |
| Awesome Profile READMEs | [github.com/abhisheknaiidu/awesome-github-profile-readme](https://github.com/abhisheknaiidu/awesome-github-profile-readme) |
| Profile README Generator | [rahuldkjain.github.io/gh-profile-readme-generator](https://rahuldkjain.github.io/gh-profile-readme-generator/) |

---

## 🤝 Katkıda Bulunma

Bu eğitim materyallerini geliştirmek için katkılarınızı bekliyoruz!

### 💡 Nasıl Katkıda Bulunabilirsiniz?

1. **🍴 Fork yapın** - Bu repoyu fork edin
2. **🌿 Branch oluşturun** - `git checkout -b feature/yeni-ozellik`
3. **✏️ Değişiklik yapın** - İyileştirmelerinizi ekleyin
4. **📝 Commit yapın** - `git commit -m "feat: yeni özellik eklendi"`
5. **📤 Push yapın** - `git push origin feature/yeni-ozellik`
6. **🔀 PR açın** - Pull Request oluşturun

### 📋 Katkı Türleri

| Tür | Açıklama |
|:----|:---------|
| 📝 **İçerik** | Yeni konular, açıklamalar, örnekler |
| 🐛 **Hata Düzeltme** | Yazım hataları, yanlış bilgiler |
| 🌍 **Çeviri** | İngilizce çeviri desteği |
| 🎨 **Tasarım** | Diyagramlar, görseller |
| 💻 **Kod** | Örnek projeler, alıştırmalar |

### 📜 Katkı Kuralları

- Commit mesajlarında [Conventional Commits](https://www.conventionalcommits.org) kullanın
- Türkçe karakter kullanımına dikkat edin
- Yeni içerik eklerken mevcut formatı takip edin
- Görseller için `assets/` klasörünü kullanın

---

## 👥 Katkıda Bulunanlar

Bu eğitim materyallerinin oluşturulmasına katkıda bulunan herkese teşekkürler!

<a href="https://github.com/Furk4nBulut/Github-Workshop/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=Furk4nBulut/Github-Workshop" />
</a>

---

## 📞 İletişim

<div align="center">

### 💬 Sorularınız mı var?

[![GitHub Discussions](https://img.shields.io/badge/💬_Discussions-Soru_Sor-blue?style=for-the-badge)](https://github.com/Furk4nBulut/Github-Workshop/discussions)
[![GitHub Issues](https://img.shields.io/badge/🐛_Issues-Hata_Bildir-red?style=for-the-badge)](https://github.com/Furk4nBulut/Github-Workshop/issues)

### 👤 Eğitmen

[![GitHub](https://img.shields.io/badge/GitHub-Furk4nBulut-181717?style=for-the-badge&logo=github)](https://github.com/Furk4nBulut)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Furkan_Bulut-0077B5?style=for-the-badge&logo=linkedin)](https://linkedin.com/in/furkanblt)

</div>

---

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) ile lisanslanmıştır.

```
MIT License

Copyright (c) 2025 Furkan Bulut

Bu yazılımın ve ilgili dokümantasyon dosyalarının bir kopyasını 
edinen herkese, kısıtlama olmaksızın yazılımı kullanma, kopyalama, 
değiştirme, birleştirme, yayınlama, dağıtma, alt lisans verme ve/veya 
satışını yapma izni ücretsiz olarak verilmektedir.
```

---

<div align="center">

## ⭐ Bu Eğitimi Beğendiyseniz

**Repo'ya yıldız vermeyi unutmayın!**

[![GitHub Stars](https://img.shields.io/github/stars/Furk4nBulut/Github-Workshop?style=social)](https://github.com/Furk4nBulut/Github-Workshop)
[![GitHub Forks](https://img.shields.io/github/forks/Furk4nBulut/Github-Workshop?style=social)](https://github.com/Furk4nBulut/Github-Workshop/fork)
[![GitHub Watchers](https://img.shields.io/github/watchers/Furk4nBulut/Github-Workshop?style=social)](https://github.com/Furk4nBulut/Github-Workshop)

---

### 🚀 Öğrenmeye Başlayın!

**[📚 Wiki'ye Git →](https://github.com/Furk4nBulut/Github-Workshop/wiki)**

---

**Made with ❤️ by [Furkan Bulut](https://github.com/Furk4nBulut)**

*Bu içerik eğitim amaçlı hazırlanmıştır ve sürekli güncellenmektedir.*

</div>
