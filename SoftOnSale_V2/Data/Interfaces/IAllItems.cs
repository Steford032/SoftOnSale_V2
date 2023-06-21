using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data.Interfaces
{
    public interface IAllItems
    {
        IEnumerable<ItemForSale> items { get; }
        IEnumerable<ItemForSale> getFavItems { get; }
        ItemForSale getItemID(int itemID);
    }
}
