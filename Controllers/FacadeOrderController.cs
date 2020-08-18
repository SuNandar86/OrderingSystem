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
            invoiceController.Sendinvoice(invoice);
            Invoice lastInvoice= invoiceController.GetLastID();
            payment.OrderID = lastInvoice.OrderID;

            PaymentController paymentController = new PaymentController();
            paymentController.MakePayment(payment);

            // Console.WriteLine("Order Placed Successfully");
             
        }
    }
}
