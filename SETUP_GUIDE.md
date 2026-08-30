# Maroko AC - FiveM PC Check System

🎮 **Professional Security System za FiveM Servere**

---

## 📋 Karakteristike

### Desktop Aplikacija (EXE)
- ✅ Cool gaming menu sa dark theme
- ✅ Brz PC scan (2-5 sekundi)
- ✅ Detektuj FiveM modove i scriptove
- ✅ Provjera opasnih stringova
- ✅ PIN sistem (6 brojeva)
- ✅ Upload rezultata na web
- ✅ Hardware info (CPU, RAM, GPU, Disk)

### Web Dashboard
- 🔍 PIN Search sekcija
- 📊 Detaljni rezultati
- 💾 Baza svih skeniranih PC-eva
- 🎯 Status indikator (CLEAN/WARNING/DANGER)
- ⚡ Real-time rezultati
- 📱 Responsive design

---

## 🚀 Brzi Start

### 1. Desktop App (EXE)
```bash
cd desktop-app
# Otvori u Visual Studio i Build
# EXE će biti u bin/Release/
```

### 2. Backend API
```bash
cd backend-api
npm install
npm run dev
```

### 3. Web Dashboard
```bash
cd web-dashboard
npm install
npm start
```

---

## 📡 Kako Radi

1. **Korisnik** pokreće EXE aplikaciju
2. **EXE** prikazuje cool menu i PIN ulaznu polje
3. Korisnik unese PIN i klikne "SCAN"
4. **EXE** skenira PC (hardware, FiveM mods, opasni stringovi)
5. **EXE** generiše PIN (6 brojeva) i uploaduje rezultate na backend
6. Korisnik ide na **Web Dashboard**
7. Unese PIN u "Results" sekciju
8. Vidi sve detalje o svom PC-u

---

## 📁 Struktura

```
MarokoacFiveM-PCCheck/
├── desktop-app/          # C# Windows Forms
│   ├── Program.cs
│   ├── MainMenuForm.cs   # Cool Gaming Menu
│   ├── PCScanner.cs      # Scan Logic
│   └── ScanResultForm.cs # Result Display
├── backend-api/          # Node.js + Express
│   ├── server.js         # Main Server
│   ├── models/Scan.js    # MongoDB Schema
│   └── routes/           # API Routes
└── web-dashboard/        # React
    ├── src/
    │   ├── App.js
    │   ├── components/
    │   │   ├── Navbar.js
    │   │   ├── PINSearch.js    # PIN Input
    │   │   └── ResultsSection.js # Show Results
    │   └── styles/
    └── public/index.html
```

---

## 🔐 PIN Sistem

- **6 brojeva** (000000 - 999999)
- **Jedinstvena** za svaki scan
- **Sigurna** za pristup rezultatima
- **Dostupna** na Web Dashboardu

---

## 💻 Sistem Zahtjevi

- Windows 7+ (za EXE)
- Node.js 14+ (za backend)
- MongoDB (lokalna ili cloud)
- Modern browser (za Web)

---

## 📊 Status Indikatori

- ✅ **CLEAN** - PC je čist, bez opasnih programa
- ⚠️ **WARNING** - Neka potencijalno sumnjiva aktivnost
- ❌ **DANGER** - Detektovani opasni programi/stringovi

---

## 🌟 Top Features

1. **Cool Menu** - Gamer aesthetic sa neon bojama
2. **Brz Scan** - Kompletna analiza PC-a za sekunde
3. **PIN Zaštita** - Samo sa PIN-om vidiš rezultate
4. **FiveM Check** - Detektuj sve custom modove
5. **Web Dostupnost** - Rezultati dostupni gdje god
6. **Risk Score** - Brojčana procjena rizika (0-100)
7. **Detaljne Info** - Hardware, software, FiveM mods

---

## 🛠️ Tehnologije

- **Desktop:** C# Windows Forms
- **Backend:** Node.js + Express + MongoDB
- **Frontend:** React + Axios
- **Database:** MongoDB
- **Design:** Dark Theme + Neon Colors

---

## 📝 Licence

Maroko AC © 2024

---

**Sada je spremno! 🚀 Koristi `npm install` i `npm start` za web, te Build u Visual Studio za EXE!**
