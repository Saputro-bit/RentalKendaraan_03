using System;
using System.Collections.Generic;
using RentalKendaraan_03.Models.RentalKendaraan.Models;

namespace RentalKendaraan_03.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }
        public string NamaJaminan { get; set; }

        public Peminjaman IdJaminanNavigation { get; set; }
    }
}
