using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    internal class User
    {
        public string Name;
        public string LastName;
        protected string Email;
        private string Password;
        public int Phone;
        public string Adress;
        private int DNI;
        public List<Product> WishList;
        public List <Product> ShoppingCart;
        public Order CreateOrder(Dictionary<Product, int> products)
        {
            return new Order();
        }
        public Review CreateReview(Product product, int rating, string comment)
        {
            return new Review();
        }
    }
}
