using System;
using System.Collections.Generic;

namespace RentalKendaraan_03.Models
{
    public partial class Nota
    {
        public DateTime TanggalTransaksi { get; set; }
        public int KodeTransaksi { get; set; }
        public string Operator { get; set; }
        public string Pelanggan { get; set; }
        public string NamaBarang { get; set; }
        public int KodeBarang { get; set; }
        public int JumlahBarang { get; set; }
        public decimal HargaBarang { get; set; }
        public decimal HargaTotal { get; set; }
        public decimal Pajak { get; set; }
        public decimal Diskon { get; set; }
    }
}
