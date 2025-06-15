
<div align="center">
  <img src="https://img.shields.io/badge/.NET-Framework-blue?style=for-the-badge" />
  <img src="https://img.shields.io/badge/WinForms-UI-green?style=for-the-badge" />
  <img src="https://img.shields.io/badge/PostgreSQL-DB-blueviolet?style=for-the-badge" />
</div>

<h1 align="center">📦 MaterialOrderingApp</h1>
<p align="center">
  <b>Manajemen Pesanan Material Bangunan</b><br>
  <i>Sistem pemesanan material untuk distributor/CV berbasis WinForms (.NET Framework) & PostgreSQL</i>
</p>

---

## 🚀 Fitur Utama

- 🔐 **Autentikasi dan Role**
  - Login, Sign Up, dan sistem multi-role (admin & customer)
- 👨‍💼 **Dashboard Admin**
  - CRUD data material (stok, harga, status)
  - Kelola pesanan dan proses pengiriman
  - Statistik user & transaksi
- 🧑 **Dashboard Customer**
  - Pemesanan material dengan antarmuka sederhana
  - Riwayat & status pesanan
  - Dukungan pembayaran COD & Transfer
- 📊 **DataGridView Modern**
  - Tampilan profesional dan intuitif
- ⚡ **UI Responsif & Interaktif**
  - Efek hover, font konsisten (Verdana), tema dark/colorful

---

## 📸 Cuplikan Layar

<p align="center">
  <img src="https://github.com/lllyeaan/Simba-App/assets/admin_dashboard_example.png" width="400" alt="Admin Dashboard"/>
  <img src="https://github.com/lllyeaan/Simba-App/assets/customer_dashboard_example.png" width="400" alt="Customer Dashboard"/>
  <br>
  <i>Contoh tampilan Admin & Customer Dashboard</i>
</p>

---

## 🛠️ Struktur Proyek

```
MaterialOrderingApp/
│
├── Forms/
│   ├── Admin/          # UI & backend admin
│   ├── Customer/       # UI & backend customer
│   └── UserControls/   # Komponen umum (Login, Register, dll)
│
├── Models/             # Model data (User, Material, Order, Delivery)
├── Repositories/       # Akses data ke PostgreSQL
├── Services/           # Business logic & jembatan UI-DB
├── Utils/              # Helper functions, DB connection, dll
├── Properties/         # Resource WinForms (.resx, image, icon)
└── README.md
```

---

## ⚙️ Cara Instalasi & Menjalankan

### 1. Clone Repositori
```bash
git clone https://github.com/lllyeaan/Simba-App.git
cd materialorderingapp
```

### 2. Buka di Visual Studio
- Pilih file `.sln` → klik **Open**.

### 3. Setup Database PostgreSQL
- Import file `database.sql` (disediakan dalam folder `db/` bila tersedia)
- Pastikan file `DbConnectionHelper.cs` sudah sesuai:
  - `host`, `user`, `password`, `database`

### 4. Jalankan Aplikasi
- Tekan **F5** atau klik **Run**
- Login sebagai admin atau buat akun customer baru

---

## 🧪 Akun Default

- **Admin**
  - Username: `AdminSimba`
  - Password: `admin123`
- **Customer**
  - Bisa dibuat dari halaman Sign Up aplikasi

---

## 📦 Kontribusi

Kami membuka kontribusi:

1. Fork repo ini
2. Buat branch: `feature/nama-fitur`
3. Commit perubahan
4. Buka pull request

---
