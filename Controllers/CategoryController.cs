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
    public class CategoryController
    {
        CategoryDataAccess DataAccess;

        public CategoryController()
        {
            DataAccess = new CategoryDataAccess();
        }
        public CategoryCollections GetCategoryList()
        {
            CategoryCollections collection = new CategoryCollections();
            IDataReader reader = DataAccess.SelectList();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryID = Convert.ToInt32(reader["category_id"]);
                category.CategoryName = Convert.ToString(reader["category_name"]);

                collection.Add(category);
            }
            return collection;
        }
    }
}
