using E_Commerce.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Models
{
    public class Cart
    {
        private List<Cartline> _cardLines = new List<Cartline>();
        public List<Cartline> Cartlines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Product.Id == product.Id);

            if (line == null)
            {
                _cardLines.Add(new Cartline(){Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double Total()
        {
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }

    }

    public class Cartline
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}