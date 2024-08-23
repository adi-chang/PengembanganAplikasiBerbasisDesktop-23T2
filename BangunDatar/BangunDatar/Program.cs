using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace BangunDatar
{
  internal class Program
  {
    static void Main(string[] args)
    {

      int pil;

      IBangunDatar obj = null;

      while (true)
      {
        Clear();
        WriteLine("HITUNG LUAS DAN KELILING BANGUN DATAR");
        WriteLine("-------------------------------------");
        WriteLine("1. Persegi Panjang");
        WriteLine("2. Bujur Sangkar");
        WriteLine("3. Lingkaran");
        WriteLine("0. Exit");
        WriteLine("-------------------------------------");

        do
        {
          Write("Bangun Datar [0/1/2/3] ? ");
          string jwb = ReadLine();
          if (int.TryParse(jwb, out pil))
          {
            break;
          }
          WriteLine("Sorry, pilihan anda salah ...");
        } while (true);




        switch (pil)
        {
          case 1:
            Clear();
            WriteLine("HITUNG LUAS DAN KELILING PERSEGI PANJANG");
            WriteLine("----------------------------------------");
            double p = GetValue("Nilai Panjang");
            double l = GetValue("Nilai Lebar  ");
            obj = new PersegiPanjang(p, l);
            WriteLine();
            WriteLine("Output:");
            WriteLine("-------");
            WriteLine($"Luas     = {obj.Luas(),8:n2}");
            WriteLine($"Keliling = {obj.Keliling(),8:n2}");
            ReadKey();
            break;
          case 2:
            Clear();
            WriteLine("HITUNG LUAS DAN KELILING BUJUR SANGKAR");
            WriteLine("--------------------------------------");
            double s = GetValue("Nilai Sisi");
            obj = new BujurSangkar(s);
            WriteLine();
            WriteLine("Output:");
            WriteLine("-------");
            WriteLine($"Luas     = {obj.Luas(),8:n2}");
            WriteLine($"Keliling = {obj.Keliling(),8:n2}");
            ReadKey();
            break;
          case 3:
            Clear();
            WriteLine("HITUNG LUAS DAN KELILING LINGKARAN");
            WriteLine("----------------------------------");
            double r = GetValue("Nilai Jari-Jari");
            obj = new Lingkaran(r);
            WriteLine();
            WriteLine("Output:");
            WriteLine("-------");
            WriteLine($"Luas     = {obj.Luas(),8:n2}");
            WriteLine($"Keliling = {obj.Keliling(),8:n2}");
            ReadKey();
            break;
        }

        if (pil == 0) {
          Clear();
          WriteLine("Bye ...");
          break;
        }

      }
    }

    static double GetValue(string prompt)
    {
      do
      {
        Write($"{prompt} ? ");
        string jwb = ReadLine();
        if (double.TryParse(jwb, out double value)) return value;
        WriteLine("Sorry, nilai data yang anda input tidak valid ...");
      } while (true);
    }

  }
}
