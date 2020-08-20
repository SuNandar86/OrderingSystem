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
    public class CustomerController
    {
        CustomerDataAccess DataAccess;
        public CustomerController()
        {
            DataAccess = new CustomerDataAccess();
        }
       
        public CustomerCollections GetCustomerList()
        {
            CustomerCollections collection = new CustomerCollections();
            IDataReader reader = DataAccess.SelectList();
            
            Customer cust= new Customer();
            cust.CustomerID = 0;
            cust.CustomerName = "Select Customer";
            collection.Add(cust); 

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerID = Convert.ToInt32(reader["customer_id"]);
                customer.CustomerName = Convert.ToString(reader["customer_name"]);
                customer.CustomerPhone = Convert.ToString(reader["customer_phone"]);
                customer.CustomerAddress = Convert.ToString(reader["customer_address"]);

                collection.Add(customer);

            }
            return collection;
        }
        public void Create(Customer customer)
        {
            DataAccess.insert(customer.CustomerName,customer.CustomerPhone,customer.CustomerAddress,customer.CustomerEmail,customer.Gender);
        }
    }
}
