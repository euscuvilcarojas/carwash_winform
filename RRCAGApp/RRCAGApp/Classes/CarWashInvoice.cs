using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCAGApp.Classes
{
    public class CarWashInvoice
    {

        public CarWashInvoice(decimal subTotal, decimal pst, decimal gst, decimal total) {
            SubTotal = subTotal;
            PST = pst;
            GST = gst;
            Total = total;
        }

        public decimal SubTotal{ get; set; }
        public decimal PST { get; set; }
        public decimal GST { get; set; }
        public decimal Total { get; set; }
    }
}
