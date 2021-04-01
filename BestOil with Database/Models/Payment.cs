using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_with_Database.Models
{
    public class Payment
    {
        public string Name { get; set; }
        public double Liter { get; set; }
        public double Pay { get; set; }
        public DateTime PaymentDateTime { get; set; }

    }
}
