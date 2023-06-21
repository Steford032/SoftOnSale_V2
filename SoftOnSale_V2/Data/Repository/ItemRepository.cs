using Microsoft.EntityFrameworkCore;
using SoftOnSale_V2.Data.Interfaces;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data.Repository
{
    public class ItemRepository : IAllItems
    {

        private readonly AppDBContent appDBContent;

        public ItemRepository(AppDBContent appDbContValue)
        {
            this.appDBContent = appDbContValue;
        }
        public IEnumerable<ItemForSale> items => appDBContent.Item.Include(c => c.category);

        public IEnumerable<ItemForSale> getFavItems => appDBContent.Item.Where(p => p.isFav).Include(c => c.category);

        public ItemForSale getItemID(int itemID) => appDBContent.Item.FirstOrDefault(p => p.id == itemID);
    }
}
