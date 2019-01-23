using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public int memberID { get; set; }
        public int expertID { get; set; }
        public bool confirmation { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        
        public virtual Member Member { get; set; }
        public virtual Expert Expert { get; set; }
    }
}