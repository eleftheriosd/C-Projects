using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_11_4.Models
{
    public class BigViewModel
    {
       // public int BigViewModelId { get; set; }
      //  public IEnumerable<Cart> Carts { get; set; }
       // public IEnumerable<Customer> Customers { get; set; }
      //  public IEnumerable<Order> Orders { get; set; }
       // public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
        public IEnumerable<Room> Rooms { get; set; }

      //  public IEnumerable<AuthenticateUser> AspnetUsers { get; set; }

    }
}
