using System;
using System.Collections.Generic;
using RentalKendaraan_03.Models.RentalKendaraan.Models;

namespace RentalKendaraan_03.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public string NoPolisi { get; set; }
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }

        public Peminjaman IdKendaraan1 { get; set; }
        public JenisKendaraan IdKendaraanNavigation { get; set; }
        public object IdJenisKendaraanNavigation { get; internal set; }
    }
}
