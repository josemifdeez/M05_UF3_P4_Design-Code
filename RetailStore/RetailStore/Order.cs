using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    internal class Order
    {
        public User Buyer;
        public int OrderNumber;
        public DateTime OrderDate;
        public Dictionary<Product, int> Products;
        public float FinalPrice;
    }
}
