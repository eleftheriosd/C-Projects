using Eshop_11_4.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Eshop_11_4.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
            .Where(p => p.Product.ProductId == product.ProductId)
            .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine
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
        public virtual void RemoveLine(Product product) =>
        lineCollection.RemoveAll(l => l.Product.ProductId == product.ProductId);
        public virtual float ComputeTotalValue() =>
        lineCollection.Sum(e => e.Product.Price * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}


























//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Eshop_11_4.Models
//{
//    public class Cart
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        public int CardId { get; set; }
//        /// <summary>
//        /// 
//        /// </summary>
//        public float Price { get; set; }
//        /// <summary>
//        /// 
//        /// </summary>
//        public int NumberOfProducts { get; set; }
//    }
//}




