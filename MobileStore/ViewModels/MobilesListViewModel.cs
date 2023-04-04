using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.ViewModels
{
    public class MobilesListViewModel
    {
        public IEnumerable<Mobile> Mobiles { get; set; }
        public string CurrentCategory { get; set; }
    }
}
