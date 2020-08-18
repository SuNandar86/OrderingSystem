using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ICS.Models
{
    public class Customer
    {
      
        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        private string _customerPhone;
        public string CustomerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; }
        }
        private string _customerAddress;
        public string CustomerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
        private string _email;
        public string CustomerEmail
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
    public class CustomerCollections : Collection<Customer> { }
    }
 
