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
        public void InsertTest()
        {
            Repository<Users> repoUser = new Repository<Users>();
            int eklenen = repoUser.Insert(new Users()
            {
                Name = "aaab",
                Surname = "Yaz",
                Email = "aabb@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                userName = "aabb",
                Password = "123456",
                CreatedOn = DateTime.Now.AddHours(1),
                ModifiedOn = DateTime.Now.AddMinutes(65),
                ModifiedUserName = "aabb"
            });
        }
    }
}

