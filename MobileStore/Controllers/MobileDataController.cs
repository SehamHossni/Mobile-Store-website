using MobileStore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Repositories;
using MobileStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
using MobileStore.ViewModels;

namespace MobileStore.Controllers
{
    public class MobileDataController : Controller
    {
        private readonly IMobileRepository _mobileRepository;

        public MobileDataController(IMobileRepository mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        [HttpGet]
        public IEnumerable<MobileViewModel> LoadMoreDrinks()
        {
            IEnumerable<Mobile> dbMobiles = null;

            dbMobiles = _mobileRepository.Mobiles.OrderBy(p => p.MobileId).Take(10);

            List<MobileViewModel> mobiles = new List<MobileViewModel>();

            foreach (var dbMobile in dbMobiles)
            {
                mobiles.Add(MapDbMobileToMobileViewModel(dbMobile));
            }
            return mobiles;
        }

        private MobileViewModel MapDbMobileToMobileViewModel(Mobile dbMobile) => new MobileViewModel()
        {
            MobileId = dbMobile.MobileId,
            Name = dbMobile.Name,
            Price = dbMobile.Price,
            ShortDescription = dbMobile.ShortDescription,
            ImageThumbnailUrl = dbMobile.ImageThumbnailUrl
        };
    }
}
