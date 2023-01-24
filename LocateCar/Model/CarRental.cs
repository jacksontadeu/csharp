using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocateCar.Model
{
    public class CarRental
    {
        public long Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Car Car { get; set; } = null!;
        public Invoice? Invoice { get; set; }
        public Pessoa Pessoa { get; set; } = null!;

    }
}
