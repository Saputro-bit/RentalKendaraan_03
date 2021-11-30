using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_03.Models
{
#nullable disable

    namespace RentalKendaraan.Models
    {
        public partial class Peminjaman
        {
            public Peminjaman()
            {
                Pengembalians = new HashSet<Pengembalian>();
            }

            public int IdPeminjaman { get; set; }
            [Required(ErrorMessage = "Tanggal Peminjaman Tidak Boleh Kosong")]
            public DateTime? TglPeminjaman { get; set; }
            public int? IdKendaraan { get; set; }
            public int? IdCustomer { get; set; }
            public int? IdJaminan { get; set; }
            [Required(ErrorMessage = "Biaya Tidak Boleh Kosong")]
            public int? Biaya { get; set; }

            public virtual Customer IdCustomerNavigation { get; set; }
            public virtual Jaminan IdJaminanNavigation { get; set; }
            public virtual Kendaraan IdKendaraanNavigation { get; set; }
            public virtual ICollection<Pengembalian> Pengembalians { get; set; }
        }
    }
}