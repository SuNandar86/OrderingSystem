using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Models
{
    public class Invoice
    {
        private int _orderID;
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        private int _itemID;
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        private int _quantitiy;
        public int Quantity
        {
            get { return _quantitiy; }
            set { _quantitiy = value; }
        }
        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
