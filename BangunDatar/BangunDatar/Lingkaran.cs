using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
  internal class Lingkaran : IBangunDatar
  {
    public double R { get; set; }

    public Lingkaran(double r)
    {
      R = r;
    }

    public double Keliling()
    {
      return 2 * Math.PI * R;
    }

    public double Luas()
    {
      return Math.PI * R * R;
    }

  }
}
