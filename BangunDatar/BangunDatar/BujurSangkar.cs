using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
  internal class BujurSangkar : IBangunDatar
  {
    public double Sisi { get; set; }

    public BujurSangkar(double s)
    {
      Sisi = s;
    }

    public double Keliling()
    {
      return 4 * Sisi;
    }

    public double Luas()
    {
      return Sisi * Sisi;
    }

  }
}
