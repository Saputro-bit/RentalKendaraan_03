using System;
using System.Collections.Generic;

namespace RentalKendaraan_03.Models
{
    public partial class Peminjaman
    {
        public int IdPemimjaman { get; set; }
        public DateTime? TglPemimjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Customer IdPemimjamanNavigation { get; set; }
        public Jaminan Jaminan { get; set; }
        public Kendaraan Kendaraan { get; set; }
        public Pengembalian Pengembalian { get; set; }
    }
}
