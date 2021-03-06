﻿using System;
using System.Collections.Generic;

namespace UnibelDestekSistemi.Models.DBHandler
{
    public partial class Bilet
    {
        public Bilet()
        {
            Yanit = new HashSet<Yanit>();
        }

        public int BiletId { get; set; }
        public int FkBiletGonderenId { get; set; }
        public int? FkCalisanKullaniciId { get; set; }
        public int FkBiletDepartmanId { get; set; }
        public int FkBiletTurId { get; set; }
        public int FkBiletDurumId { get; set; }
        public int FkOncelikId { get; set; }
        public string BiletBasligi { get; set; }
        public byte[] BiletDosyasiAdi { get; set; }
        public string BiletIcerik { get; set; }
        public bool AktifMi { get; set; }
        public DateTime BiletGonderimTarihi { get; set; }
        public int? FkUrunId { get; set; }
        public DateTime? BiletKapanisTarihi { get; set; }
        public int FkSirketId { get; set; }
        public DateTime? BiletTahminiKapanısTarihi { get; set; }

        public Departman FkBiletDepartman { get; set; }
        public Durum FkBiletDurum { get; set; }
        public Kullanici FkBiletGonderen { get; set; }
        public Tip FkBiletTur { get; set; }
        public Kullanici FkCalisanKullanici { get; set; }
        public Oncelik FkOncelik { get; set; }
        public Sirketler FkSirket { get; set; }
        public Urun FkUrun { get; set; }
        public ICollection<Yanit> Yanit { get; set; }
    }
}
