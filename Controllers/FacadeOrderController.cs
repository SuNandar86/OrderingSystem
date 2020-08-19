using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICS.Models;

namespace ICS.Controllers
{
    public class FacadeOrderController
    {
        public void PlaceOrder(Invoice invoice,Payment payment)
        {
            InvoiceController invoiceController = new InvoiceController();
            int order_id=invoiceController.Sendinvoice(invoice);
            
            payment.OrderID = order_id;

            PaymentController paymentController = new PaymentController();
            paymentController.MakePayment(payment);             
             
        }
    }
}
