using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RentalKendaraan_03.Models.RentalKendaraan.Models;

namespace RentalKendaraan_03.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer Tidak Boleh Kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh Angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat Tidak Boleh Kosong")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No HP Min 10 Angka")]
        [MaxLength(13, ErrorMessage = "No HP Maks 13 Angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
        public object Gender { get; internal set; }
    }
}