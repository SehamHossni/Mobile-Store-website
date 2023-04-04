using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class ProductWishlistItem
    {
        [Key]
        public int ProductWishlistItemId { get; set; }
        public Mobile Mobile { get; set; }
        public int Amount { get; set; }
        public string ProductWishlistId { get; set; }
    }
}
