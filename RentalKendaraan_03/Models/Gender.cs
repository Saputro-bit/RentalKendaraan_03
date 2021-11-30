using System;
using System.Collections.Generic;

namespace RentalKendaraan_03.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }
        public string NamaGender { get; set; }

        public Customer IdGenderNavigation { get; set; }
        public object Customers { get; internal set; }
    }
}
