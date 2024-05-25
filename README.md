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
antara dua individu serta memanfaatkan Regular Expression untuk menyocokkan nama pada basis data yang dienkripsi dengan bahasa alay.
--- BELUM LENGKAP, HARUS ADA PENJELASAN KMP, BM, DAN REGEX ---

## Requirement Program
1. Dotnet
2. Visual Studio 2022 (.NET Desktop Development)
3. MySQLConnector for Visual Studio 2022
4. SQL DBMS (e.g. MariaDB)

## Cara Menggunakan Program
1. Clone repository dengan cara membuka terminal lalu masukkan perintah berikut
   ```sh
   git clone https://github.com/nicholasrs05/Tubes3_Albertus.git
   ```
2. Buka folder path berikut: src/Albertus_FingerprintMatcher/bin/Debug
3. Buka file executable bernama Albertus_FingerprintMatcher.exe
4. Aplikasi akan meminta masukan citra sidik jari yang ingin dicocokkan dengan basis data dan jenis algoritma yang ingin digunakan.
6. Program akan menampilkan citra sidik jari yang paling mirip (bila ada), biodata individu terkait, dan waktu pencarian.

## Credits

Dalam pengembangan aplikasi ini, kami menggunakan dataset sidik jari dari [SOCOFing](https://www.kaggle.com/datasets/ruizgara/socofing)
dan algoritma konversi ke [Bahasa_Alay](https://alaygenerator.blogspot.com/)
