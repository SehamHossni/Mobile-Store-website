using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class MobileReviewsViewModel : Controller
    {
        public Mobile mobile { get; set; }
        public List <Review > reviews{ get; set; }
    }
   
}
