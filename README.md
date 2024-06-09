# Tugas Besar 3 IF2211 Strategi Algoritma Semester II tahun 2023/2024
# Pemanfaatan Pattern Matching dalam Membangun Sistem Deteksi Individu Berbasis Biometrik Melalui Citra Sidik Jari

### Dibuat oleh:
| Nama | NIM |
| -------- | --------- |
| Andi Marihot Sitorus | 13522138 |
| Nicholas Reymond Sihite | 13522144 |
| Muhammad Dzaki Arta | 13522149 |

## Deskripsi Aplikasi
Aplikasi ini adalah aplikasi berbasis desktop yang digunakan untuk memanfaatkan algoritma KMP dan BM untuk melakukan pencocokan sidik jari
antara sidik jari masukan (diambil 60 pixel) dengan sidik jari pada basis data (seluruh pixel) serta memanfaatkan Regular Expression untuk menyocokkan nama pada basis data yang dienkripsi dengan bahasa alay. Kedua algoritma tersebut hanya dapat mencocokkan dua sidik jari yang persis sama, kecuali kebetulan ada pixel yang sama dari 60 pixel yang diambil. Jika tidak ditemukan kesamaan, aplikasi akan menggunakan Hamming Distance untuk mencocokkan sidik jari. Kemiripan yang diterima aplikasi adalah lebih dari atau sama dengan 70%, di luar itu akan dianggap berbeda.


## Requirements Aplikasi
1. Dotnet
2. Visual Studio 2022 (.NET Desktop Development)
3. MySQLConnector for Visual Studio 2022
4. SQL DBMS (e.g. MariaDB)

## Cara Menggunakan Aplikasi
1. Clone repository dengan cara membuka terminal lalu masukkan perintah berikut
   ```sh
   git clone https://github.com/nicholasrs05/Tubes3_Albertus.git
   ```
2. Buka folder path berikut: test
3. Unzip "Real.zip" sehingga menghasilkan struktur folder test/Real/isi_folder
4. Buka folder path berikut: src/Albertus_FingerprintMatcher/database
5. Masukkan file "tubes3_albertus.sql" ke sebuah basis data
6. Buka solution "Albertus_FingerprintMatcher.sln" pada Visual Studio 2022
7. Pada solution explorer, klik kanan "Albertus_FingerprintMatcher.cs", klik Add, References, lalu masukkan MySQLConnector
8. Buka file "DatabaseManager.cs", lalu ubah nama database, username, dan password pada konstruktor sesuai DBMS Anda
9. Tekan tombol "Start", aplikasi seharusnya dapat berjalan
10. Aplikasi akan meminta masukan citra sidik jari yang ingin dicocokkan dengan basis data dan jenis algoritma yang ingin digunakan.
11. Program akan menampilkan citra sidik jari yang paling mirip (bila ada), biodata individu terkait, dan waktu pencarian.

## Credits

Dalam pengembangan aplikasi ini, kami menggunakan dataset sidik jari dari [SOCOFing](https://www.kaggle.com/datasets/ruizgara/socofing)
dan algoritma konversi ke [Bahasa_Alay](https://alaygenerator.blogspot.com/)