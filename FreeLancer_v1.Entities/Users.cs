using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.Entities
{
    [Table("Tbl_Kullanıcılar")]
    public class Users : MyEntitiyDatabase
    {
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Surname { get; set; }
        [StringLength(25), Required]
        public string userName { get; set; }

        [StringLength(75), Required]
        public string Email { get; set; }
        [StringLength(75), Required]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public Guid ActivateGuid { get; set; }
        public bool IsAdmin { get; set; }


        public virtual List<Notes> Notlar { get; set; }
        public virtual List<Comment> Yorumlar { get; set; }
        public virtual List<Liked> Likes { get; set; }
    }
}
