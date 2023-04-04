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
    public class ShoppingCartController : Controller
    {
        private readonly IMobileRepository _mobileRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMobileRepository mobileRepository, ShoppingCart shoppingCart)
        {
            _mobileRepository = mobileRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

       [Authorize]
        public RedirectToActionResult AddToShoppingCart(int mobileId)
        {
            var selectedMobile = _mobileRepository.Mobiles.FirstOrDefault(p => p.MobileId == mobileId);
            if (selectedMobile != null)
            {
                _shoppingCart.AddToCart(selectedMobile, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int mobileId)
        {
            var selectedMobile = _mobileRepository.Mobiles.FirstOrDefault(p => p.MobileId == mobileId);
            if (selectedMobile != null)
            {
                _shoppingCart.RemoveFromCart(selectedMobile);
            }
            return RedirectToAction("Index");
        }
    }
}
