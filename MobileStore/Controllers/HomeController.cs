using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;
using MobileStore.ViewModels;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMobileRepository _mobileRepository;
        public HomeController(IMobileRepository mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredMobiles = _mobileRepository.PreferredMobiles
            };
            return View(homeViewModel);
        }
    }
}
