using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftOnSale_V2.ViewModels;
using SoftOnSale_V2.Models;
using SoftOnSale_V2.Data.Interfaces;

namespace SoftOnSale_V2.Controllers
{

    public class ItemsController : Controller
    {
        private readonly IAllItems _allItems;
        private readonly ICategoryOfItem _allCategories;


        public ItemsController(IAllItems itemObjects, ICategoryOfItem itemCategories)
        {
            _allItems = itemObjects;
            _allCategories = itemCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "All accounts";
            ItemsListViewModels obj = new ItemsListViewModels();
            obj.allItems = _allItems.items;
            obj.currentCategory = "*Список аккаунтов";
            return View(obj);
        }

        public IActionResult Index()
        {
            var result = _allItems;
            return View(result);
        }

        
    }
}
