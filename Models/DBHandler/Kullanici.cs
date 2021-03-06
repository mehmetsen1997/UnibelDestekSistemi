﻿using System;
using System.Collections.Generic;

namespace UnibelDestekSistemi.Models.DBHandler
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            BiletFkBiletGonderen = new HashSet<Bilet>();
            BiletFkCalisanKullanici = new HashSet<Bilet>();
            Duyuru = new HashSet<Duyuru>();
            Yanit = new HashSet<Yanit>();
        }

        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string TamIsim { get; set; }
        public string Eposta { get; set; }
        public byte[] ProfilFotografi { get; set; }
        public int? FkDepartmanId { get; set; }
        public int FkSirketId { get; set; }
        public int? FkRolId { get; set; }
        public string KullaniciTel { get; set; }
        public string Unvan { get; set; }
        public DateTime? EpostaSilmeZamani { get; set; }
        public string Link { get; set; }

        public Departman FkDepartman { get; set; }
        public Roller FkRol { get; set; }
        public Sirketler FkSirket { get; set; }
        public ICollection<Bilet> BiletFkBiletGonderen { get; set; }
        public ICollection<Bilet> BiletFkCalisanKullanici { get; set; }
        public ICollection<Duyuru> Duyuru { get; set; }
        public ICollection<Yanit> Yanit { get; set; }
    }
}
