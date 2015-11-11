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
                            Name = "ҳ���",
                            Weight = 150
                        },
                        new Ingredient
                        {
                            Name = "������� ����������",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "������� ������",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "������� �������",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "��� �������",
                            Weight = 35
                        },
                        new Ingredient
                        {
                            Name = "�������",
                            Weight = 50
                        },
                        new Ingredient
                        {
                            Name = "�����",
                            Weight = 60
                        },
                        new Ingredient
                        {
                            Name = "�����",
                            Weight = 60
                        },
                        new Ingredient
                        {
                            Name = "�����",
                            Weight = 40
                        },
                    }                    
                    );
            }
        }
    }
}
