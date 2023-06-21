using SoftOnSale_V2.Data.Interfaces;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data.Repository
{
    public class CategoryRepository : ICategoryOfItem
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDbContValue)
        {
            this.appDBContent = appDbContValue;
        }
        //For getting all categories values we refer to 'appDBContent'
        public IEnumerable<Category> AllCategories => appDBContent.Category; 
    }
}
