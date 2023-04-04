using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using MobileStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace MobileStore.Controllers
{

    public class MobileController : Controller
    {
        private readonly IMobileRepository _mobileRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MobileController(IMobileRepository mobileRepository, ICategoryRepository categoryRepository)
        {
            _mobileRepository = mobileRepository;
            _categoryRepository = categoryRepository;
        }
       
        public ActionResult GetMobileComment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetmobileComment()
        {
            MobileReviewsViewModel MRVM = new MobileReviewsViewModel();
            MRVM.mobile = GetBlogModel();
            MRVM.reviews = GetCommentModel();
            return View(MRVM);
        }
        public Mobile GetBlogModel()
        {
            Mobile MModel = new Mobile()
            {
                MobileId = 1,
                Name = "samsung s21",
                ShortDescription = "any thing",
                LongDescription="any thing",
                Price=21000,
                ImageUrl="dsdas",
                ImageThumbnailUrl="jdsf",
                IsPreferredMobile=true,
                InStock=true,
                CategoryId=1
               
            };
            return MModel;
        }

        public List<Review> GetCommentModel()
        {
            List<Review> cModel = new List<Review>();

            cModel.Add(new Review()
            {
                ReviewId = 1,
                ParentId = 1,
                Content = "Good One",
                UserId = "hdfjdf",
                Username = "ahmed",
                MobileId = 123,
                Rating = 5,
                Sent = DateTime.Now

            });
            cModel.Add(new Review()
            {
                ReviewId = 1,
                ParentId = 1,
                Content = "Good One",
                UserId = "hdfjdf",
                Username = "ahmed",
                MobileId = 123,
                Rating = 5,
                Sent = DateTime.Now

            });
            return cModel;
        }
            public async  Task<ViewResult> Index(string category, int pageIndex=1,int pageSize = 9)
        {
            string _category = category;
            IOrderedQueryable<Mobile> mobiles;//= _mobileRepository.Mobiles;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                mobiles = _mobileRepository.Mobiles.OrderBy(p => p.MobileId);
                currentCategory = "All mobiles";
            }
            else
            {
                if (string.Equals("IPhone", _category, StringComparison.OrdinalIgnoreCase))
                    mobiles = _mobileRepository.Mobiles.Where(p => p.Category.CategoryName.Equals("IPhone")).OrderBy(p => p.Name);
                else
                    mobiles = _mobileRepository.Mobiles.Where(p => p.Category.CategoryName.Equals("Samsung")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            var model = await PagingList.CreateAsync<Mobile>(
                           mobiles, pageSize, pageIndex);
            return View("List", model/*new MobilesListViewModel
            {
                Mobiles = mobiles,
               // CurrentCategory = currentCategory
            }*/);
        }

        //public ViewResult Search(string searchString)
        //{
        //    string _searchString = searchString;
        //    IEnumerable<Mobile> mobiles;
        //    string currentCategory = string.Empty;

        //    if (string.IsNullOrEmpty(_searchString))
        //    {
        //        mobiles = _mobileRepository.Mobiles.OrderBy(p => p.MobileId);
        //    }
        //    else
        //    {
        //        mobiles = _mobileRepository.Mobiles.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
        //    }

        //    return View("~/Views/Mobile/List.cshtml", new MobilesListViewModel { Mobiles = mobiles, CurrentCategory = "All mobiles" });
        //}
        public async Task<ViewResult> Search(string searchString, int page = 1)
        {
            string _searchString = searchString;
            IOrderedQueryable<Mobile> mobiles;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                mobiles = _mobileRepository.Mobiles.OrderBy(p => p.MobileId);
            }
            else
            {
                mobiles = _mobileRepository.Mobiles.Where(p => p.Name.ToLower().Contains(_searchString.ToLower())).OrderBy(p => p.Name); ;
            }
            var modelsearch = await PagingList.CreateAsync<Mobile>(
                           mobiles, 10, page);

            modelsearch.RouteValue = new RouteValueDictionary {
        { "filter", searchString} };

            return View("List", modelsearch);
            //return View("~/Views/Mobile/List.cshtml", new MobilesListViewModel { Mobiles = mobiles, CurrentCategory = "All mobiles" });
        }

        public ViewResult Details(int mobileId)
        {
            var mobile = _mobileRepository.Mobiles.FirstOrDefault(d => d.MobileId == mobileId);
            if (mobile == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(mobile);
        }
    }
}
