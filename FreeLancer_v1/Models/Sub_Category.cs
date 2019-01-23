using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class Sub_Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sub_CategoryID { get; set; }
        public string name { get; set; }
        public int topCategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<Expert> Experts { get; set; }
    }
}