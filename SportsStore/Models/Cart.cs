﻿using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class Cart
    {
        public List<CartLine> Lines { get; set; }=new List<CartLine>();
        public void AddItem(Product product,int quantity)
        {
            CartLine line = Lines
                            .Where(x => x.Product.ProductID==product.ProductID)
                            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Product product)
        {
            Lines.RemoveAll(l=> l.Product.ProductID==product.ProductID);
        }
        public decimal ComputeTotalValue()
        {
            return Lines.Sum(x=>x.Product.Price * x.Quantity);
        }

        public void Clear()
        {
            Lines.Clear();
        }
    }
}
