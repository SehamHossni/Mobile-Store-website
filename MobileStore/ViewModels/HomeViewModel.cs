using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Models;

namespace MobileStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Mobile> PreferredMobiles { get; set; }
    }
}
