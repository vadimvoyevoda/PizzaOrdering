namespace DataModel.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModel.PizzaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataModel.PizzaContext context)
        {
            using (var ctx = new PizzaContext())
            {
                ctx.Ingredients.AddRange(
                    new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Тісто",
                            Weight = 150
                        },
                        new Ingredient
                        {
                            Name = "Ковбаса мисливська",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "Ковбаса варена",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "Ковбаса сервілат",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "Сир твердий",
                            Weight = 35
                        },
                        new Ingredient
                        {
                            Name = "Помідори",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "Гриби",
                            Weight = 60
                        },
                        new Ingredient
                        {
                            Name = "Курка",
                            Weight = 60
                        },
                        new Ingredient
                        {
                            Name = "Шинка",
                            Weight = 40
                        },
                    }                    
                    );
            }
        }
    }
}
