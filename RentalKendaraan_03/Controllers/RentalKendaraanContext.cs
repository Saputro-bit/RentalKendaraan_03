using System;
using System.Threading.Tasks;

namespace RentalKendaraan_03.Controllers
{
    internal class RentalKendaraanContext
    {
        public object Customer { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}