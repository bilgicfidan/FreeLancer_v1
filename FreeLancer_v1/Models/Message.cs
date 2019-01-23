using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class Message
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }

        public int memberID { get; set; }
        public int expertID { get; set; }
        public string content { get; set; }
        public DateTime dateClock { get; set; }
        
        public virtual Member Member { get; set; }
        public virtual Expert Expert { get; set; }
    }
}