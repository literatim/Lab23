using Lab21.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Lab21.DAL
{
    public class PersonDbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var items = new List<Items>
            {
                new Items {Name = "Dark Roast", Description = "Spicy bean juice", Quantity = 1, Price = 5.00},
            };

            items.ForEach(s => context.Items.AddOrUpdate(s));

            context.SaveChanges();

        }

    }
}