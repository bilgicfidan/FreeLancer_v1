using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [StringLength(50), Required]
        public string name { get; set; }

        public virtual List<Expert> Experts { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Sub_Category> Sub_Categories { get; set; }
    }
}