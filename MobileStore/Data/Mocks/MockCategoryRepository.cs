using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;

namespace MobileStore.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "IPhone", Description = "All IPhone phones" },
                         new Category { CategoryName = "Samsung", Description = "All Samsung phones" }
                     };
            }
        }
    }
}
