using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.Entities
{
    [Table("Tbl_Yorumlar")]
    public class Comment : MyEntitiyDatabase
    {
        [Required, StringLength(300)]
        public string Text { get; set; }

        public virtual Notes Notlar { get; set; }
        public virtual Users Kullanici { get; set; }
        public Comment()
        {

        }
    }
}