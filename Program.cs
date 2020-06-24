using System;
using Collection.induk;
using Collection.anak;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) -- Polymorphism, Abstraction & Collection ";

            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "142-213-153";
            karyawantetap.Nama = "Elsa Ardianti Friani";
            karyawantetap.GajiBulanan = 2000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "113-221-142";
            karyawanharian.Nama = "Thanty Alfhany";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 80000;

            Sales sales = new Sales();
            sales.Nik = "542-110-213";
            sales.Nama = "Firmina Wenni";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 65000;
            // objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} Nama: {2} Gaji: {3:N0}",
                    noUrut,
                    karyawan.Nik,
                    karyawan.Nama,
                    karyawan.TotalGaji());

                noUrut++;
            }
            

            Console.ReadKey();
        }
    }
}
