using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftOnSale_V2.Data.Interfaces;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data.mocks
{
    public class MockCategory : ICategoryOfItem
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>{
                    new Category{ categoryName = "Аккаунты", description = "Общий игровой аккаунт с несколькими продуктами"},
                    new Category{ categoryName = "Ключи", description = "Личный ключ с цифровым продуктом"}
                };
            }
        }
    }
}
