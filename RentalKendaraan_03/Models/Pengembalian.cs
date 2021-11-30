using System;
using System.Collections.Generic;
using RentalKendaraan_03.Models.RentalKendaraan.Models;

namespace RentalKendaraan_03.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public Peminjaman IdPengembalian1 { get; set; }
        public KondisiKendaraan IdPengembalianNavigation { get; set; }
        public object IdKondisiNavigation { get; internal set; }
        public object IdPeminjamanNavigation { get; internal set; }
    }
}
