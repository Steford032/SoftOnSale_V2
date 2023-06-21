using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftOnSale_V2.Models
{
    public class ItemForSale
    {

        public int id { get; set; }

        public string name { get; set; }

        public string shortDescription { get; set; }

        public string longDescription { get; set; }

        public string img { set; get; }

        public ushort price { get; set; }

        public bool isFav { get; set; }

        public bool available { get; set; }

        public int categoryID { get; set; }

        public virtual Category category { get; set; }
    }
}
