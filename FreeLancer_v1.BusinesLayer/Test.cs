using FreeLancer_v1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.BusinesLayer
{
    public class Test
    {
        public Test()
        {
            Repository<Categories> repo = new Repository<Categories>();
            List<Categories> kategorilerim = repo.List();
        }
    }
}
