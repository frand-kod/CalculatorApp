
# Aplikasi Kalkulator WinForms

Aplikasi ini adalah kalkulator sederhana yang dibuat menggunakan Windows Forms (WinForms) di .NET. Aplikasi ini mendukung operasi dasar seperti penambahan, pengurangan, perkalian, dan pembagian.

## Fitur

- **Operasi Matematika:** Penambahan, Pengurangan, Perkalian, Pembagian.
- **Pilihan Operasi:** Pengguna dapat memilih jenis operasi dari ComboBox.

## Instalasi

1. Clone repositori ini ke lokal Anda:

    ```bash
    git clone https://github.com/frand-kod/CalculatorApp.git
    ```

2. Buka proyek menggunakan Visual Studio.

3. Jalankan proyek dengan menekan tombol `Start` atau `F5`.

## Cara Penggunaan

1. Masukkan nilai `A` dan `B` pada kotak input yang tersedia.
2. Pilih operasi yang diinginkan (Penambahan, Pengurangan, Perkalian, Pembagian) dari `ComboBox`.
3. Klik tombol `Hitung` untuk melihat hasil operasi.

## Contoh Kode

### Pemilihan Operasi Default

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    comboBoxOperasi.Items.Add("Penambahan");
    comboBoxOperasi.Items.Add("Pengurangan");
    comboBoxOperasi.Items.Add("Perkalian");
    comboBoxOperasi.Items.Add("Pembagian");

    comboBoxOperasi.SelectedIndex = 0; // Pilihan default: Penambahan
}
```

## Kontribusi

Saran, kritik, dan kontribusi Anda untuk program ini sangat saya hargai. Jika ingin menambah fitur baru atau memperbaiki bug yang ada, silakan buat pull request atau buka issue.

## Lisensi

Proyek ini dilisensikan di bawah [MIT License](LICENSE).
