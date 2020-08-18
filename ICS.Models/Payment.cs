using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Models
{
    public class Payment
    {
        private int _paymentID;
        public int PaymentID
        {
            get { return _paymentID; }
            set { _paymentID = value; }
        }
        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        private int _orderID;
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        private string _paymentType;
        public string PaymentType
        {
            get { return _paymentType; }
            set { _paymentType = value; }
        }
        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private DateTime _paymentDate;
        public DateTime PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }
    }
}
