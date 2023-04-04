using MobileStore.Data.Models;
using MobileStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Components
{
    public class ProductWishlistSummary : ViewComponent
    {
        private readonly ProductWishlist _productWishlist;
        public ProductWishlistSummary(ProductWishlist productWishlist)
        {
            _productWishlist = productWishlist;
        }

        public IViewComponentResult Invoke()
        {
            var items = _productWishlist.GetProductWishlistItems();
            _productWishlist.ProductWishlistItems = items;

            var productWishlistViewModel = new ProductWishlistViewModel
            {
                ProductWishlist = _productWishlist,
                ProductWishlistTotal = _productWishlist.GetWishListTotal()
            };
            return View(productWishlistViewModel);
        }
    }
}