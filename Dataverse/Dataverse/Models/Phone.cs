using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dataverse.Models
{
    public class Phone
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int PhoneId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Contact Contact { get; set; }
    }
}