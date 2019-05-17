using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeLancer_v1.Models
{
    public class ViewModelClass
    {
        public IEnumerable<Expert> HomeExpert { get; set; }
        public IEnumerable<Category> HomeCategory { get; set; }
        public IEnumerable<Sub_Category> HomeSubCategories { get; set; }
    }
}