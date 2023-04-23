using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace B9Katalog
{
    public class Album
    {
        public string izvodjac { get; set; }
        public string naziv { get; set; }
        public string zanr { get; set; }
        public int godina { get; set; }
        public string izdavac { get; set; }
        public string slika { get; set; }

        public Album(string izvodjac, string naziv, string zanr, int godina, string izdavac, string slika)
        {
            this.izvodjac = izvodjac;
            this.naziv = naziv;
            this.zanr = zanr;
            this.godina = godina;
            this.izdavac = izdavac;
            this.slika = slika;
        }

        public static List<Album> ucitaj(StreamReader r)
        {
            List<Album> sviAlbumi = new List<Album>();

            while (!r.EndOfStream)
            {
                string[] p = r.ReadLine().Split('|');
                Album a = new Album(p[0], p[1], p[2], int.Parse(p[3]), p[4], p[5]);
                sviAlbumi.Add(a);
            }
            return sviAlbumi;
        }
    }
}