using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Konversi_Suhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear(); //Membersihkan tampilan konsol sebelum menampilkan menu, membuat tampilan lebih bersih saat perulangan.
                Console.WriteLine("===== Aplikasi Konversi Suhu =====");
                Console.WriteLine("Pilih Salah Satu Menu:");
                Console.WriteLine("1. Celcius ke Fahrenheit");
                Console.WriteLine("2. Celcius ke Kelvin");
                Console.WriteLine("3. Celcius ke Reamur");
                Console.WriteLine("4. Exit");
                Console.WriteLine("==================================");
                Console.Write("\n Masukkan pilihan Anda: ");

                string pilihan = Console.ReadLine();

                double celcius, hasil;

                switch (pilihan)
                {
                    case "1":
                        Console.Write("\n Masukkan suhu dalam Celcius: ");
                        celcius = Convert.ToDouble(Console.ReadLine());
                        hasil = (celcius * 9 / 5) + 32; // Rumus Celcius ke Fahrenheit
                        Console.WriteLine("\n ========= HASIL KONVERSI =========");
                        Console.WriteLine("\n Hasil Konversi: {0} Celcius = {1} Fahrenheit", celcius, hasil);
                        break;

                    case "2":
                        Console.Write("\n Masukkan suhu dalam Celcius: ");
                        celcius = Convert.ToDouble(Console.ReadLine());
                        hasil = celcius + 273; // Rumus Celcius ke Kelvin
                        Console.WriteLine("\n ========= HASIL KONVERSI =========");
                        Console.WriteLine("\n Hasil Konversi: {0} Celcius = {1} Kelvin", celcius, hasil);
                        break;

                    case "3":
                        Console.Write("\n Masukkan suhu dalam Celcius: ");
                        celcius = Convert.ToDouble(Console.ReadLine());
                        hasil = celcius * 4 / 5; // Rumus Celcius ke Reamur
                        Console.WriteLine("\n ========= HASIL KONVERSI =========");
                        Console.WriteLine("\n Hasil Konversi: {0} Celcius = {1} Reamur", celcius, hasil);
                        break;

                    case "4":
                        isRunning = false; // Keluar dari program
                        Console.WriteLine("\n Terima kasih telah menggunakan aplikasi ini.");
                        break;

                    default:
                        Console.WriteLine("\n Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }

                if (isRunning)
                {
                    Console.Write("\n Apakah kamu ingin mengulang program? [y/n] ");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "y") { 
                        isRunning = true;
                    }
                    else if (choice == "n") {
                        Console.WriteLine("\n Program Dihentikan ");
                        isRunning = false;
                    }
                }

            }
        }
    }
}
