using System;
using System.Collections.ObjectModel;

namespace ICS.Models
{
    public class Product
    {
        private int _productID;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
    public class ProductCollections : Collection<Product> { }
}
