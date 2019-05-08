using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_11_4.Models
{
    public class Room
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int RoomId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<Product> Products
        {
            get;
            set;
        }
    }
}
