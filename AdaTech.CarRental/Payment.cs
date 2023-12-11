using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    public class Payment
    {
        public double totalValue {  get; set; }
        public PaymentMethod paymentMethod { get; set; }

        public bool status { get; set; }

        public Payment(double totalValue, PaymentMethod pm)
        {
            this.totalValue = totalValue;
            this.paymentMethod = pm;
            status = false;
        }


    }
}
