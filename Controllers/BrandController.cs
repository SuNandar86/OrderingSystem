using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICS.Models;
using ICS.DataAccess;
using System.Data;

namespace Controllers
{
    public class BrandController
    {
        BrandDataAccess DataAccess;

        public BrandController()
        {
            DataAccess = new BrandDataAccess();
        }
        public BrandCollections GetCategoryList(int category_id)
        {
            BrandCollections collection = new BrandCollections();
            IDataReader reader = DataAccess.SelectList(category_id);
            while (reader.Read())
            {
                Brand brand = new Brand();
                brand.BrandID = Convert.ToInt32(reader["brand_id"]);
                brand.BrandName = Convert.ToString(reader["brand_name"]);

                collection.Add(brand);
            }
            return collection;
        }
    }
}
