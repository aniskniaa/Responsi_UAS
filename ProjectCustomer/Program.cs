using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = " Responsi UAS Matakuliah Pemrograman ";

            while (true)
            {
                TampilMenu();

                Console.Write("\n Nomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.WriteLine(" Pilih Menu Aplikasi\n ");
            Console.WriteLine(" 1. Tambah Customer ");
            Console.WriteLine(" 2. Hapus Customer ");
            Console.WriteLine(" 3. Tampilkan Customer ");
            Console.WriteLine(" 4. Keluar ");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection

            Customer customer = new Customer();
            Console.WriteLine(" Tambah Data Customer \n");

            Console.Write(" Kode Customer : ");
            customer.Kode = Console.ReadLine();

            Console.Write(" Nama Customer : ");
            customer.Nama = Console.ReadLine();

            Console.Write(" Total Utang   : Rp.");
            customer.Utang = double.Parse(Console.ReadLine());

            daftarCustomer.Add(customer);

            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection

            Console.WriteLine(" Hapus Data Customer \n");

            Console.Write(" Kode Customer : ");
            string kode = Console.ReadLine();

            for (int i = 0; i < daftarCustomer.Count; i++)
            {
                if (daftarCustomer[i].Kode == kode)
                {
                    daftarCustomer.Remove(daftarCustomer[i]);
                    Console.WriteLine("\n Data Customer berhasil di hapus");
                }
                else
                {
                    Console.WriteLine("\n Kode Customer tidak ditemukan ");
                }
            }



            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection

            Console.WriteLine(" Data Customer \n");

            int noUrut =  1;

            foreach (Customer customer in daftarCustomer)
            {
                Console.WriteLine(" {0}. Kode: {1}, Nama: {2}, Total Utang: Rp.{3:n0}", noUrut, customer.Kode, customer.Nama, customer.Utang);

                noUrut++;
            }

            Console.WriteLine("\n Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
