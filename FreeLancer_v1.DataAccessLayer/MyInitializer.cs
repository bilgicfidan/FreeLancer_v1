using FreeLancer_v1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLancer_v1.DataAccessLayer
{
    public class MyInıtilazier : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Users admin = new Users();
            admin.Name = "Mahmut";
            admin.Surname = "Yazıcı";
            admin.Email = "jsdajdsa@gmail.com";
            admin.ActivateGuid = Guid.NewGuid();
            admin.IsAdmin = true;
            admin.IsActive = true;
            admin.userName = "yazicimah";
            admin.Password = "123456";
            admin.CreatedOn = DateTime.Now;
            admin.ModifiedOn = DateTime.Now.AddMinutes(5);
            admin.ModifiedUserName = "mahyaz";

            Users normalKul = new Users()
            {
                Name = "Zekiye",
                Surname = "Yaz",
                Email = "zekiye@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                userName = "zekiye5",
                Password = "123456",
                CreatedOn = DateTime.Now.AddHours(1),
                ModifiedOn = DateTime.Now.AddMinutes(65),
                ModifiedUserName = "zky"


            };

            context.dB_Kullanicilar.Add(admin);
            context.dB_Kullanicilar.Add(normalKul);

            context.SaveChanges();

            for (int i = 0; i < 8; i++)
            {
                Users user = new Users()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    ActivateGuid = Guid.NewGuid(),
                    IsActive = true,
                    IsAdmin = false,
                    userName = $"user{i}",
                    Password = "123",
                    CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                    ModifiedUserName = $"user{i}"


                };
                context.dB_Kullanicilar.Add(user);
            }
            context.SaveChanges();

            //Kullanıcılar select edilip userList'e atıldı.
            List<Users> userList = context.dB_Kullanicilar.ToList();


            //Categori adding...
            for (int i = 0; i < 10; i++)
            {
                Categories cat = new Categories()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedUserName = "modifiedMah"
                };

                context.dB_Kategoriler.Add(cat);

                for (int k = 0; k < FakeData.NumberData.GetNumber(5, 9); k++)
                {
                    Users basamak = userList[FakeData.NumberData.GetNumber(0, userList.Count - 1)];
                    Notes not = new Notes()
                    {
                        Title = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5, 25)),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 3)),
                        IsDraft = false,
                        LikeCount = FakeData.NumberData.GetNumber(1, 9),
                        Kullanici = basamak,
                        CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUserName = basamak.userName
                    };
                    cat.Notlar.Add(not);

                    //Adding Comments...

                    for (int j = 0; j < FakeData.NumberData.GetNumber(3, 5); j++)
                    {
                        Users basamak2 = userList[FakeData.NumberData.GetNumber(0, userList.Count - 1)];
                        Comment yorum = new Comment()
                        {
                            Text = FakeData.TextData.GetSentence(),
                            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            Kullanici = basamak2,
                            ModifiedUserName = basamak2.userName,
                        };
                        not.Yorumlar.Add(yorum);
                    }

                    //Likes Adding...

                    for (int m = 0; m < not.LikeCount; m++)
                    {
                        Liked begeniler = new Liked()
                        {
                            LikedUser = userList[m]
                        };
                        not.Likes.Add(begeniler);
                    }
                }
            }

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

        }
    }
}
     