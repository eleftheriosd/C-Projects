using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_11_4.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("ProductType")]
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  virtual ProductType ProductType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Room Room { get; set; }
        public ICollection<CartLine> Lines { get; set; }
    }
}
