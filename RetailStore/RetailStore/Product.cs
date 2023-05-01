using System;
using System.Collections.Generic;

namespace RetailStore
{
    public abstract class Product
    {
        public int ID;
        public string Name;
        public string Brand;
        public List<string> Images;
        public string Description;
        public float BasePrice;
        public float Discount;
        private List<string> Tags;
        public bool haveDiscount()
        {
            return true;
        }
        private bool Visible()
        {
            return true;
        }
    }

    public class SimpleProducts : Product 
    { 
        public enum Category { }
        public enum SubCategory { }
    }

    public class SpecialProducts : Product
    {
        public enum Category { }
        public enum SubCategory1 { }
        public enum SubCategory2 { }
    }
}
