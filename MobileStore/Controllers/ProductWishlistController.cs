using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using MobileStore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MobileStore.Controllers
{
    public class ProductWishlistController : Controller
    {
        private readonly IMobileRepository _mobileRepository;
        private readonly ProductWishlist _productWishlist;

        public ProductWishlistController(IMobileRepository mobileRepository, ProductWishlist productWishlist)
        {
            _mobileRepository = mobileRepository;
            _productWishlist = productWishlist;
        }

        [Authorize]
        public ViewResult Index()
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

        [Authorize]
        public RedirectToActionResult AddToWishList(int mobileId)
        {
            var selectedMobile = _mobileRepository.Mobiles.FirstOrDefault(p => p.MobileId == mobileId);
            if (selectedMobile != null)
            {
                _productWishlist.AddToWishList(selectedMobile, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromWishList(int mobileId)
        {
            var selectedMobile = _mobileRepository.Mobiles.FirstOrDefault(p => p.MobileId == mobileId);
            if (selectedMobile != null)
            {
                _productWishlist.RemoveFromWishList(selectedMobile);
            }
            return RedirectToAction("Index");
        }
    }
}

