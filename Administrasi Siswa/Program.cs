using System;
using System.IO;

namespace AdministrasiSiswa
{
    /// <summary>
    /// main class
    /// </summary>
    public class Administrasi
    {
        /// <summary>
        /// Operasi data siswa
        /// </summary>
        /// <param name="a">angka pertama dalam operasi mendefinisikan data siswa</param>
        /// <param name="b"></param>
        /// </summary>
        private object sw;

        public void administrasi()
        {
            //mendeklarasikan atau mendefinisikan variabel data menggunakan array
            string[] Nama = new string[35];
            string[] Nim = new string[35];
            string[] Kelas = new string[35];
            string[] Alamat = new string[35];
            string[] Jk = new string[35];
            string[] Ds = new string[35];

            int i, n = 0;
            //menginput jumlah data Siswa yang ingin diinputkan 
            Console.WriteLine("     Data Administrasi Siswa     ");
            Console.WriteLine("=================================");
            Console.Write("Masukkan Jumlah Siswa =  ");
            Console.Write("\n");
            n = int.Parse(Console.ReadLine());
            //mengisi data yang diinputkan user dengan perulangan for 
            for (i = 1; i <= n; i++)
            {
                //menampilkan 'Masukkan Data Siswa ke-' variabel i
                Console.WriteLine("Masukkan Data Siswa ke-" + i);
                Console.WriteLine("===========================");
                Console.Write('\n');
                //menampilkan Masukkan Nama Siswa
                Console.Write("Masukkan Nama Siswa = ");
                Nama[i] = Console.ReadLine();
                //menampilkan Masukkan Nomor Induk Siswa
                Console.Write("Masukkan Nomor Siswa = ");
                Nim[i] = Console.ReadLine();
                //menampilkan Masukkan Jenis Kelamin
                Console.Write("Masukkan Jenis Kelamin = ");
                Jk[i] = Console.ReadLine();
                //menampilkan Masukkan Alamat
                Console.Write("Masukkan Alamat = ");
                Alamat[i] = Console.ReadLine();
                //menampilkan Masukkan Kelas
                Console.Write("Masukkan Kelas = ");
                Kelas[i] = Console.ReadLine();
                //menampilkan Masukkan Nama Guru
                Console.Write("Masukkan Nama Guru = ");
                Ds[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Data Telah Dimasukkan, Tekan Sembarang Untuk Menampilkan Data");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("          Data Administrasi Siswa Yang Telah Anda Inputkan          ");
            Console.WriteLine("====================================================================");
            Console.Write("\n");
            Console.WriteLine("NO  |  Nama  |  NIM  |  Jenis Kelamin  |  Alamat  |  Kelas  |  Guru");

            //menampilkan hasil dari data yang telah dimasukkan oleh user dengan perulangan for 
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(" " + i + "     " + Nama[i] + "\t" + Nim[i] + "\t  " + Jk[i] + "\t           " + Alamat[i] + "\t       " + Kelas[i] + "\t " + Ds[i]);
            }
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamWriter sw = new StreamWriter(Path.Combine(path, $"Administrasi Siswa.txt"));
                sw.WriteLine("NO  |  Nama  |  NIM  |  Jenis Kelamin  |  Alamat  |  Kelas  |  Dosen");
                for (i = 1; i <= n; i++)
                {
                    sw.WriteLine(" " + i + "     " + Nama[i] + "\t" + Nim[i] + "\t  " + Jk[i] + "\t            " + Alamat[i] + "\t       " + Kelas[i] + "\t " + Ds[i]);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }


            Console.WriteLine();
            Console.Write("Tekan 'ENTER' untuk keluar.....");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //memanggil class administrasi siswa
            Administrasi Admnst = new Administrasi();
            Admnst.administrasi();
        }
    }
}