using MobileStore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MobileStore.Data.Repositories
{
    public class MobileRepository : IMobileRepository
    {
        private readonly AppDbContext _appDbContext;
        public MobileRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IOrderedQueryable<Mobile> Mobiles => _appDbContext.Mobiles.Include(c => c.Category).OrderBy(i=>i.MobileId );

        public IEnumerable<Mobile> PreferredMobiles => _appDbContext.Mobiles.Where(p => p.IsPreferredMobile).Include(c => c.Category);

        public Mobile GetMobileById(int mobileId) => _appDbContext.Mobiles.FirstOrDefault(p => p.MobileId == mobileId);
    }
}
