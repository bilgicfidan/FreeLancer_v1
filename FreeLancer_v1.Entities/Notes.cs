using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.Entities
{
    [Table("Tbl_Notlar")]
    public class Notes:MyEntitiyDatabase
    {
        [Required, StringLength(60)]
        public string Title { get; set; }
        [Required, StringLength(2000)]
        public string Text { get; set; }
        public bool IsDraft { get; set; }
        public int LikeCount { get; set; }
        public int CategoryId { get; set; }

        public Users Kullanici { get; set; }
        public virtual List<Comment> Yorumlar { get; set; }
        public Categories Kategori { get; set; }
        public virtual List<Liked> Likes { get; set; }
        public Notes()
        {
            Yorumlar = new List<Comment>();
            Likes = new List<Liked>();
        }
    }
}
