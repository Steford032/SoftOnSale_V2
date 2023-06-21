using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data.Interfaces
{
    public interface ICategoryOfItem
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
