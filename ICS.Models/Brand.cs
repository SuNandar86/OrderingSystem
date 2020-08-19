using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ICS.Models
{
    public class Brand
    {
        private int _brandID;
        public int BrandID
        {
            get { return _brandID; }
            set { _brandID = value; }
        }

        private int _categoryID;
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        private string _brandName;
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }
    }
    public class BrandCollections : Collection<Brand> { }
}
