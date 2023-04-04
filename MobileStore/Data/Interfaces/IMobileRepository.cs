using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Models;

namespace MobileStore.Data.Interfaces
{
    public interface IMobileRepository
    {
        IOrderedQueryable<Mobile> Mobiles { get; }
        IEnumerable<Mobile> PreferredMobiles { get; }
        Mobile GetMobileById(int MobileId);
    }
}
