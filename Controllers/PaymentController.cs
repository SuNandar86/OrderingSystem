using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICS.Models;
using ICS.Models;
using ICS.DataAccess;
using System.Data;

namespace ICS.Controllers
{
    public class PaymentController
    {
        PaymentDataAccess DataAccess;
        public PaymentController()
        {
            DataAccess = new PaymentDataAccess();
        }
        public void MakePayment(Payment payment)
        {
            DataAccess.insert(payment.OrderID,payment.CustomerID,payment.PaymentType,payment.Amount,payment.PaymentDate);
        }
    }
}
