using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.Entities
{
    [Table("Tbl_Kategoriler")]
   public class Categories : MyEntitiyDatabase
    {
        [Required]
        public string Title { get; set; }
        [StringLength(150)]
        public string Description  { get; set; }

        public virtual List<Notes> Notlar { get; set; }
        public Categories()
        {
            Notlar = new List<Notes>();
        }
    }
}
