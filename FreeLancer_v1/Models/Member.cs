using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int memberID { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(20)]
        public string lastname { get; set; }

        [Index(IsUnique = true)]
        [StringLength(20), Required(ErrorMessage = "{0} boş geçilemez.")]
        public string nickname { get; set; }

        [StringLength(50), Required(ErrorMessage ="{0} boş geçilemez.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Geçersiz Email adresi!")]
        [DataType(DataType.EmailAddress)]
        public string email{ get; set; }

        [StringLength(30), Required(ErrorMessage = "{0} boş geçilemez.")]
        [DataType(DataType.Password)]
        public string password{ get; set; }


        public int role{ get; set; }

        public string image_url{ get; set; }

        public DateTime dateOfMembership{ get; set; }

        [MaxLength(25), DataType(DataType.PhoneNumber)]
        public string phoneNumber { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Message> Messages { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}