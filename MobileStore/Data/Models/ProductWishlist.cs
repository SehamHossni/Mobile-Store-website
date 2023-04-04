using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MobileStore.Data.Models
{
    public class ProductWishlist
    {
        private readonly AppDbContext _appDbContext;
        private ProductWishlist(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ProductWishlistId { get; set; }

        public List<ProductWishlistItem> ProductWishlistItems { get; set; }

        public static ProductWishlist GetWish(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string wishId = session.GetString("WishId") ?? Guid.NewGuid().ToString();

            session.SetString("WishId", wishId);

            return new ProductWishlist(context) { ProductWishlistId = wishId };
        }

        public void AddToWishList(Mobile mobile, int amount)
        {
            var productWishlistItem =
                    _appDbContext.ProductWishlistItems.SingleOrDefault(
                        s => s.Mobile.MobileId == mobile.MobileId && s.ProductWishlistId == ProductWishlistId);

            if (productWishlistItem == null)
            {
                productWishlistItem = new ProductWishlistItem
                {
                    ProductWishlistId = ProductWishlistId,
                    Mobile = mobile,
                    Amount = 1
                };

                _appDbContext.ProductWishlistItems.Add(productWishlistItem);
            }
            else
            {
                productWishlistItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromWishList(Mobile mobile)
        {
            var productWishlistItem =
                    _appDbContext.ProductWishlistItems.SingleOrDefault(
                        s => s.Mobile.MobileId == mobile.MobileId && s.ProductWishlistId == ProductWishlistId);

            var localAmount = 0;

            if (productWishlistItem != null)
            {
                if (productWishlistItem.Amount > 1)
                {
                    productWishlistItem.Amount--;
                    localAmount = productWishlistItem.Amount;
                }
                else
                {
                    _appDbContext.ProductWishlistItems.Remove(productWishlistItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ProductWishlistItem> GetProductWishlistItems()
        {
            return ProductWishlistItems ??
                   (ProductWishlistItems =
                       _appDbContext.ProductWishlistItems.Where(c => c.ProductWishlistId == ProductWishlistId)
                           .Include(s => s.Mobile)
                           .ToList());
        }

        public void ClearWishList()
        {
            var wishItems = _appDbContext
                .ProductWishlistItems
                .Where(cart => cart.ProductWishlistId == ProductWishlistId);

            _appDbContext.ProductWishlistItems.RemoveRange(wishItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetWishListTotal()
        {
            var total = _appDbContext.ProductWishlistItems.Where(c => c.ProductWishlistId == ProductWishlistId)
                .Select(c => c.Mobile.Price * c.Amount).Sum();
            return total;
        }
    }
}
