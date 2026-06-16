using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent_Managment
{
    public class CustomerPaymentMethod
    {
        private string paymentMethod;
        private string paymentMedium;

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        public string PaymentMedium
        {
            get { return paymentMedium; }
            set { paymentMedium = value; }
        }
    }
}
