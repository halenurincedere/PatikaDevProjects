# 🃏 Card-Game (Hafıza Oyunu)

> React ve Redux kullanılarak geliştirilmiş bir hafıza oyunu. Kart çiftlerini eşleştir, puan kazan ve tüm kartları açınca oyunu yeniden başlat!

---

## 🚀 Özellikler

* 5x5 matris üzerinde kart çiftleri rastgele dağıtılır.
* İki kart üst üste açıldığında:

  * Aynı ise: kartlar açık kalır ve **+50 puan** eklenir.
  * Farklı ise: kartlar otomatik kapanır ve **-10 puan** düşülür.
* Kullanıcı puanı ekranın üst kısmında gösterilir.
* Tüm kartlar açıldığında "Yeniden Oyna" butonu çıkar, tıklanınca kartlar kapanır ve yeniden karışır.
* Footer kısmında LinkedIn ve GitHub bağlantıları sabit altta yer alır.

---

## 🧰 Kullanılan Teknolojiler

* React.js
* Redux Toolkit
* Vite.js
* CSS3

---

## 📂 Proje Yapısı

```
Card-Game/
├─ public/
├─ src/
│  ├─ components/
│  │  ├─ Card.jsx
│  │  ├─ Card.css
│  │  ├─ Footer.jsx
│  ├─ redux/
│  │  ├─ gameSlice.js
│  │  ├─ store.js
|  ├─ Footer.css
│  ├─ App.jsx
│  ├─ App.css
│  ├─ main.jsx
├─ index.html
├─ package.json
└─ vite.config.js
```

---

## ⚙️ Kurulum

1️⃣ Projeyi klonlayın:

```bash
git clone https://github.com/kullanici_adi/Card-Game.git
```

2️⃣ Bağımlılıkları yükleyin:

```bash
npm install
```

3️⃣ Çalıştırın:

```bash
npm run dev
```

4️⃣ Tarayıcıda açın: [http://localhost:5173](http://localhost:5173)

---

## 🤝 Katkı

Katkı yapmak isterseniz issue açabilir veya pull request gönderebilirsiniz.

---

## 📧 İletişim

💡 Ekin Öztürk — [LinkedIn](https://www.linkedin.com/in/ekin-%C3%B6zt%C3%BCrk-a06659249/) | [GitHub](https://github.com/ekinnn35)

---

> İyi eğlenceler! 🎯
