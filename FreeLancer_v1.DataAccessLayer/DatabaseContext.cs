using FreeLancer_v1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.DataAccessLayer
{
   public class DatabaseContext : DbContext
    {
        public DbSet<Notes> dB_Notlar { get; set; }
        public DbSet<Users> dB_Kullanicilar { get; set; }
        public DbSet<Categories> dB_Kategoriler { get; set; }
        public DbSet<Comment> dB_Yorumlar { get; set; }
        public DbSet<Liked> dB_Likes { get; set; }

    }
}
