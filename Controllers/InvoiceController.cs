using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICS.Models;
using ICS.DataAccess;
using System.Data;

namespace ICS.Controllers
{
    public class InvoiceController
    {
        InvoiceDataAccess DataAccess;
        
        public InvoiceController()
        {
            DataAccess = new InvoiceDataAccess();
        }
        public int Sendinvoice(Invoice invoice)
        {
            int order_id= DataAccess.insert(invoice.CustomerID, invoice.ItemID, invoice.Quantity, invoice.Amount,invoice.InvoiceDate);
            return Convert.ToInt32(order_id);
        }        
    }
}
