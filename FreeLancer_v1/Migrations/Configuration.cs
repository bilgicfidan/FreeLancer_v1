namespace FreeLancer_v1.Migrations
{
    using FreeLancer_v1.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<FreeLancer_v1.Models.Managers.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "FreeLancer_v1.Models.Managers.DatabaseContext";
        }

        protected override void Seed(FreeLancer_v1.Models.Managers.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            try
            {
                
                //for (int i = 0; i < 10; i++)
                //{
                //    context.Members.Add(new Models.Member
                //    {
                //        name = FakeData.NameData.GetFirstName(),
                //        lastname = FakeData.NameData.GetSurname(),
                //        nickname = FakeData.NameData.GetFirstName(),
                //        email = FakeData.NetworkData.GetEmail(),
                //        password = FakeData.TextData.GetAlphaNumeric(10),
                //        phoneNumber = FakeData.PhoneNumberData.GetPhoneNumber(),
                //        role=0,
                //        image_url = null,
                //        dateOfMembership = FakeData.DateTimeData.GetDatetime(),
                    
                //    });
                //}
                
                //context.SaveChanges();
            }
            catch (DbEntityValidationException dbValEx)
            {
                var outputLines = new StringBuilder();
                foreach (var eve in dbValEx.EntityValidationErrors)
                {
                    outputLines.AppendFormat("{0}: Entity of type {1} in state {2} has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.AppendFormat("- Property: {0}, Error: {1}", ve.PropertyName, ve.ErrorMessage);
                    }
                }

                //Tools.Notify(this, outputLines.ToString(),"error");
                throw new DbEntityValidationException(string.Format("Validation errorsrn {0}", outputLines.ToString()), dbValEx);
            }
        }
    }
}
