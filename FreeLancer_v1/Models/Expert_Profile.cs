using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class Expert_Profile
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int expertID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string workImageUrl { get; set; }

        [Required]
        public virtual Expert Expert { get; set; }
        
    }
}