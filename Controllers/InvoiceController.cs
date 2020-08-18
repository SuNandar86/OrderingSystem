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
        public void Sendinvoice(Invoice invoice)
        {
            DataAccess.insert(invoice.CustomerID, invoice.ItemID, invoice.Quantity, invoice.Amount);
             
        }
        public Invoice GetLastID()
        {
             
            IDataReader reader = DataAccess.getLastID();
            Invoice invoice = new Invoice();
            while (reader.Read())
            {
                invoice.OrderID = Convert.ToInt32(reader["order_id"]); 
            }
            return invoice;
        }
    }
}
