using Alpha_Alchohols.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpha_Alchohols.DAL
{
    public class LiquorInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LiquorContext>
    {
        protected override void Seed(LiquorContext context)
        {
            /*
            var Liquors = new List<Liquor>
            {
            new Liquor { liquorName = "Blue Sea", liquorCost = 39.99, liquorInventory = .4},
            new Liquor { liquorName = "Captain Morgan", liquorCost = 52.99, liquorInventory = .8 },
            new Liquor { liquorName = "Bombay Fire", liquorCost = 36.99, liquorInventory = .3 },
            new Liquor { liquorName = "Bacardi Rum", liquorCost = 25.99, liquorInventory = .7},
            new Liquor { liquorName = "Puchin", liquorCost = 43.99, liquorInventory = .5 },
            new Liquor { liquorName = "Triple Barcadi", liquorCost = 11.99, liquorInventory = .8},
            new Liquor { liquorName = "Dry Martini", liquorCost = 9.99, liquorInventory = .2},
            new Liquor { liquorName = "Black Hennesy", liquorCost = 56.99, liquorInventory = .1 }
            };

            Liquors.ForEach(s => context.Liquors.Add(s));
            context.SaveChanges();

            var Cocktails = new List<Cocktail>
            {
            new Cocktail { cocktailName = "Filly Gag", cocktailPrice = 11.00 },
            new Cocktail { cocktailName = "AK47", cocktailPrice = 12.00 },
            new Cocktail { cocktailName = "Gin Martini", cocktailPrice = 14.00 },
            new Cocktail { cocktailName = "African Hi", cocktailPrice = 13.00 },
            new Cocktail { cocktailName = "Margarita", cocktailPrice = 9.00 },
            new Cocktail { cocktailName = "Diablo", cocktailPrice = 12.00 }
            };

            Cocktails.ForEach(s => context.Cocktails.Add(s));
            context.SaveChanges();

            var Ingredients = new List<Ingredient>
            {
            new Ingredient { IngID = 0, IngName = "Lemon Juice"},
            new Ingredient { IngID = 1, IngName = "Lime Juice" },
            new Ingredient { IngID = 2, IngName = "Sugar Cube" },
            new Ingredient { IngID = 3, IngName = "Orange" },
            new Ingredient { IngID = 4, IngName = "Cherry" },
            new Ingredient { IngID = 5, IngName = "olive" }
            };

            Ingredients.ForEach(s => context.Ingredients.Add(s));
            context.SaveChanges();

            var MonthlyCosts = new List<MonthlyCost>
            {
            new MonthlyCost { Month = "June", CurrentInventoryCost = 4100,PreviousMonth = "May", PreviousInventoryCost = 3995, Difference = -1895, MonthlySales = 8845 },
            new MonthlyCost { Month = "July", CurrentInventoryCost = 3500, PreviousMonth = "June", PreviousInventoryCost =  4100, Difference = 600, MonthlySales = 2953},
            new MonthlyCost { Month = "August", CurrentInventoryCost = 3700, PreviousMonth = "July", PreviousInventoryCost =  2400, Difference = 1300, MonthlySales = 5800}
            };
            MonthlyCosts.ForEach(s => context.MonthlyCosts.Add(s));
            context.SaveChanges(); */
        }

    }
}