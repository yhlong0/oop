﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
