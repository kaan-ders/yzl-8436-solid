using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LS
{
    public abstract class Sekil
    {
        protected int Yukseklik { get; set; }
        protected int Genislik { get; set; }
        protected int Yaricap { get; set; }
        protected int Hipotenus { get; set; }

        public abstract int AlanHesapla();
        public abstract int CevreHesapla();
        public int HipotenusHesapla()
        {
            return Hipotenus;
        }
    }

    public class Kare : Sekil
    {
        public Kare(int kenar)
        {
            Yukseklik = kenar;
            Genislik = kenar;
        }

        public override int AlanHesapla()
        {
            //karenin alan hesaplaması
            return Yukseklik * Genislik;
        }

        public override int CevreHesapla()
        {
            //karenin çevre hesaplaması
            return Yukseklik + Genislik;
        }

        //public override int HipotenusHesapla()
        //{
        //    //???
        //    return 0;
        //}
    }

    public class Dikdortgen : Sekil
    {
        public Dikdortgen(int yukseklik, int genislik)
        {
            Yukseklik = yukseklik;
            Genislik = genislik;
        }

        public override int AlanHesapla()
        {
            //karenin alan hesaplaması
            return Yukseklik * Genislik;
        }

        public override int CevreHesapla()
        {
            //karenin çevre hesaplaması
            return Yukseklik + Genislik;
        }

        //public override int HipotenusHesapla()
        //{
        //    return Hipotenus;
        //    //???
        //}
    }

    public class Daire : Sekil
    {
        public Daire(int yaricap)
        {
            Yaricap = yaricap;
        }

        public override int AlanHesapla()
        {
            return Yaricap * 2;
        }

        public override int CevreHesapla()
        {
            return Yukseklik * 3;
        }

        //public override int HipotenusHesapla()
        //{
        //    return 0;
        //}
    }

    public class Ucgen : Sekil
    {
        public Ucgen(int kenar1, int kenar2, int kenar3)
        {
            Yukseklik = kenar1;
            Genislik = kenar2;
            Hipotenus = kenar3;
        }

        public override int AlanHesapla()
        {
            return Yukseklik * Genislik * Hipotenus;
        }

        public override int CevreHesapla()
        {
            return Hipotenus * 3;

            //HakedisHesapla()
            //HipotenusHesapla()
        }

        //public override int HipotenusHesapla()
        //{
        //    return Hipotenus;
        //}
    }
}
