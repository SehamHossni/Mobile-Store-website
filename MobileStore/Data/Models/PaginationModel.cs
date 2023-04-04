using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MobileStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class PaginationModel : PageModel
    {
       
        public PaginationModel(MobilesListViewModel mobilesListViewModel)
        {
            Data = mobilesListViewModel;
            Count = mobilesListViewModel.Mobiles.Count();
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public MobilesListViewModel Data { get; set; }

    }
}
