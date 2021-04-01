using BestOil_with_Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_with_Database.Data
{
    public class PaymentContext:DbContext
    {
        public PaymentContext() : base("PaymentDb")
        {

        }
        public DbSet<Payment> Payments { get; set; }
    }
}
