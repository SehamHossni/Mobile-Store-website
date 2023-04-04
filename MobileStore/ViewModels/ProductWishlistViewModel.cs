using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Models;

namespace MobileStore.ViewModels
{
    public class ProductWishlistViewModel
    {
        public ProductWishlist ProductWishlist { get; set; }
        public decimal ProductWishlistTotal { get; set; }
    }
}
