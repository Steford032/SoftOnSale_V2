using SoftOnSale_V2.Data.Interfaces;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data
{

    //Class, that filling Database with objects (goods)
    public class DBcontent
    {
        private static Dictionary<string, Category> category;

        public static void Initial (AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Item.Any())
            {
                content.AddRange(
                    new ItemForSale
                {
                    name = "Valheim",
                    shortDescription = "brutal exploration survival game",
                    longDescription = "An open-world survival game played from a third-person perspective." +
                        " As fallen Vikings, you must craft tools, build shelters and fight enemies to survive. ",
                    img = "https://shorturl.at/qzR58",
                    price = 99,
                    isFav = true,
                    available = true,
                    category = Categories["Аккаунты"]
                },

                    new ItemForSale
                    {
                        name = "Friday the 13th",
                        shortDescription = "3d-person multiplayer horror, survival game",
                        longDescription = "Survival is entirely up to you, the player, as you either stealthily " +
                        "hide from Jason or work together as a team to escape or bring the fight to Jason.",
                        img = "https://shorturl.at/dAJRU",
                        price = 119,
                        isFav = true,
                        available = true,
                        category = Categories["Аккаунты"]
                    },

                    new ItemForSale
                    {
                        name = "Rust",
                        shortDescription = "Multiplayer survival video game",
                        longDescription = "You wake naked on a mysterious island armed only with " +
                        "a rock and a torch. You'll need to brave natural dangers solo or with a team.",
                        img = "https://shorturl.at/BTZ49",
                        price = 229,
                        isFav = false,
                        available = true,
                        category = Categories["Аккаунты"]
                    },

                    new ItemForSale
                    {
                        name = "Atomic Heart",
                        shortDescription = "1st-person shooter game with RPG elements, sending you back to the USSR",
                        longDescription = "Welcome to a utopian world of wonders and perfection, " +
                        "in which humans live in harmony with their loyal and fervent robots.",
                        img = "https://shorturl.at/hnuC0",
                        price = 1499,
                        isFav = false,
                        available = true,
                        category = Categories["Ключи"]
                    }
                );
            }
            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Аккаунты", description = "Общий игровой аккаунт с несколькими продуктами"},
                        new Category{ categoryName = "Ключи", description = "Личный ключ с цифровым продуктом"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category obj in list)
                        category.Add(obj.categoryName, obj);
                }
                return category;
            }
        }
    }
}
