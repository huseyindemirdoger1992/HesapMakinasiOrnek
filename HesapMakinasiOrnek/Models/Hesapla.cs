using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinasiOrnek.Models
{
    public class Hesapla
    {
        public double Topla(double Sayi1, double Sayi2)
        {
            double Sonuc = Sayi1 + Sayi2;
            return Sonuc;
        }

        public double Cikar(double Sayi1, double Sayi2)
        {
            double Sonuc = Sayi1 - Sayi2;
            return Sonuc;
        }

        public double Carp(double Sayi1, double Sayi2)
        {
            double Sonuc = Sayi1 * Sayi2;
            return Sonuc;
        }

        public double Bol(double Sayi1, double Sayi2)
        {
            double Sonuc = Sayi1 / Sayi2;
            return Sonuc;
        }
    }
}
