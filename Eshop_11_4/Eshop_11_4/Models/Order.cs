using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Eshop_11_4.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Last name")]
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool OrderShipped { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Please enter the Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter the address line")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter the City")]
        public string City { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }

        [ForeignKey("AuthenticateUser")]
        public string AuthenticateUserId { get; set; }
        /// <summary>
        /// 
        ///// </summary>
        public virtual AuthenticateUser AuthenticateUser { get; set; }

    }
}
