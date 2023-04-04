using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileStore.Data.Models;
using MobileStore.Data;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace MobileStore.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ILogger<ReviewController> _logger;
    private readonly AppDbContext _Context;
    private readonly UserManager<IdentityUser> _userManager;

    public ReviewController(ILogger<ReviewController> logger,
        AppDbContext appDbContext,
        UserManager<IdentityUser> userManager)
    {
        _logger = logger;
        _Context = appDbContext;
        _userManager = userManager;
    }

    public IActionResult Index(int MobileId)
    {
            ViewBag.MobileId = MobileId;
        ViewBag.Review = _Context.Reviews.Where(x => x.MobileId == MobileId).OrderBy(x => x.Sent).ToList();
            var model = _Context.Reviews.Where(x => x.MobileId == MobileId).FirstOrDefault();
        return View(model);
    }
    
        [Authorize]
    public IActionResult CreateComments(Review review)
    {
        var currentuser = _userManager.GetUserName(User);
        if (ModelState.IsValid)
        {
                //string jsonObj = JsonConvert.SerializeObject(specificationObj);
                ////save jsonObj to database;

                ////redad jsonObj from database
                ////
                //string jsonFromDB = "[]"; 

                //SpecifationClass specificationObj = JsonConvert.DeserializeObject<SpecifationClass>(jsonFromDB);

                review.Sent = DateTime.Now;
                review.Username = currentuser;
           
            _Context.Add(review);
            _Context.SaveChanges();
            ModelState.Clear();

        }
        return RedirectToAction("Details", "Mobile",new { mobileId = review.MobileId});

    }

    public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
