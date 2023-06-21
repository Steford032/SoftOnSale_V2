using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.ViewModels
{
    public class ItemsListViewModels
    {
        public IEnumerable<ItemForSale> allItems { get; set; }

        public string currentCategory { get; set; }
    }
}
