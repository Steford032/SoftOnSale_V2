using Microsoft.AspNetCore.Mvc;
using SoftOnSale_V2.Models;
using SoftOnSale_V2.Data.Interfaces;

namespace SoftOnSale_V2.Controllers
{
    public class HomeController : Controller
	{
        public static readonly List<ItemForSale> items = new List<ItemForSale>{
                    new ItemForSale {
                        name = "Valheim", shortDescription = "brutal exploration survival game",
                        longDescription = "An open-world survival game played from a third-person perspective." +
                        " As fallen Vikings, you must craft tools, build shelters and fight enemies to survive. ",
                        img = "https://shorturl.at/qzR58", price = 99,
                        isFav = true, available = true, category = null
                    },

                    new ItemForSale {
                        name = "Friday the 13th", shortDescription = "3d-person multiplayer horror, survival game",
                        longDescription = "Survival is entirely up to you, the player, as you either stealthily " +
                        "hide from Jason or work together as a team to escape or bring the fight to Jason.",
                        img = "https://shorturl.at/dAJRU", price = 119,
                        isFav = false, available = true, category = null
                    },

                    new ItemForSale {
                        name = "Rust", shortDescription = "Multiplayer survival video game",
                        longDescription = "You wake naked on a mysterious island armed only with " +
                        "a rock and a torch. You'll need to brave natural dangers solo or with a team.",
                        img = "https://shorturl.at/BTZ49", price = 229,
                        isFav = true, available = true, category = null
                    },

                    new ItemForSale {
                        name = "Atomic Heart", shortDescription = "1st-person shooter game with RPG elements, sending you back to the USSR",
                        longDescription = "Welcome to a utopian world of wonders and perfection, " +
                        "in which humans live in harmony with their loyal and fervent robots.",
                        img = "https://shorturl.at/hnuC0", price = 1499,
                        isFav = true, available = true, category = null
                    }
                };

        public IActionResult Index()
        {
            var result = items;
            return View(result);
        }


    }
}

//using Microsoft.AspNetCore.Mvc;
//using SoftOnSale_V2.Data.Interfaces;
//using SoftOnSale_V2.ViewModels;

//namespace SoftOnSale_V2.Controllers
//{
//	public class HomeController: Controller
//	{
//		private IAllItems _itemRepository;

//		public HomeController(IAllItems items)
//		{
//			_itemRepository = items;
//		}

//		public ViewResult Index()
//		{
//			var dispHomeCars = new HomeViewModel()
//			{
//				favItems = _itemRepository.getFavItems
//			};
//			return View(dispHomeCars);
//		}

//	}
//}