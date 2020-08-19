using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICS.Models;
using ICS.DataAccess;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace ICS.Controllers
{
    public class ProductController
    {
        ProductDataAccess DataAccess;
        public ProductController()
        {
            DataAccess = new ProductDataAccess();
        }
        
        public ProductCollections GetProductList(int brand_id)
        {
            ProductCollections collection = new ProductCollections();
            IDataReader reader = DataAccess.SelectList(brand_id);
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductName = Convert.ToString(reader["product_name"]);
                product.Price = Convert.ToDecimal(reader["price"]);
                product.ProductID = Convert.ToInt32(reader["product_id"]);
                collection.Add(product);

            }
            return collection;
        }
        public Product GetPrice(int product_id)
        {
            Product product = new Product();
            IDataReader reader = DataAccess.GetPrice(product_id);
            while (reader.Read())
            {
                product.ProductName = Convert.ToString(reader["product_name"]);
                product.Price = Convert.ToDecimal(reader["price"]);
                product.ProductID = Convert.ToInt32(reader["product_id"]);
            }
            return product;
        }        

    }
}
