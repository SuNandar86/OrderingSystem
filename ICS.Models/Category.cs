using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ICS.Models
{
    public class Category
    {
        private int _categoryID;
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        private string _categoryName;
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
    }
    public class CategoryCollections : Collection<Category> { }
}
