using FreeLancer_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.ViewModel.HomePageViewModel
{
    public class HomePageViewModel
    {
        public Category category { get; set; }
        public Sub_Category sub_Category { get; set; }
        public Expert expert { get; set; }
        public List<Category> categories { get; set; }
        public List<Sub_Category> sub_cat { get; set; }
        public List<Expert> experts { get; set; }
    }
}