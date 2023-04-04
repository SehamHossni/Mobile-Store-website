using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;

namespace MobileStore.Data.Mocks
{
    public class MockMobileRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Mobile> Mobiles
        {
            get
            {
                return new List<Mobile>
                {
                    new Mobile {
                        Name = "XS Max",
                        Price = 13990L, ShortDescription = "The Apple iPhone Xs Max delivers top-notch performance with the help of A12 Bionic chip.",
                        LongDescription = "The Apple iPhone Xs Max is armed with a leading-edge combination of the A12 Bionic chip and next-generation Neural Engine. It delivers a phenomenal performance, no matter if the phone is handling heavy computational tasks or everyday tasks.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/1565936397.33.jpg",
                        InStock = true,
                        IsPreferredMobile = true,
                        ImageThumbnailUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/1565936397.33.jpg"
                    },
                    new Mobile {
                        Name = "Samsung 9",
                        Price = 11600L, ShortDescription = "The Samsung Galaxy Note 9 smartphone marks the evolution of mobile technology.",
                        LongDescription = "The Samsung Galaxy smartphone is powered by a mighty 10nm Octa-core application processor, which is programmed to enhance the performance and consume minimal power for smooth functioning. A 6GB RAM further bolsters the processing speed for a lag-free performance, allowing you to multitask seamlessly.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.androidguys.com/wp-content/uploads/2019/08/Note10_Auraglow1.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "https://www.androidguys.com/wp-content/uploads/2019/08/Note10_Auraglow1.jpg"
                    },
                    new Mobile {
                        Name = "IPhone 11 ",
                        Price = 11749L, ShortDescription = "iPhone 11 smartphone is beautifully designed.",
                        LongDescription = "This Apple iPhone 11 smartphone is beautifully designed, making you fall in love with it each time you see it. The 6.1inch Liquid Retina display captivates your attention, unlike any other smartphone. The glass and aerospace-grade aluminum design make it durable and lend it heart-stealing looks.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/78877_cbe0138e-899f-457b-b3a9-423b8fac2599.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/78877_cbe0138e-899f-457b-b3a9-423b8fac2599.jpg"
                    },
                    new Mobile
                    {
                        Name = "Samsung Galaxy Note 10 ",
                        Price = 13410L,
                        ShortDescription = "The Samsung Galaxy Note 10 Dual-SIM smartphone keeps you abreast with the pace of modern-day mobile computing. ",
                        LongDescription = "This Samsung Galaxy Note 10 smartphone provides a hair-raising viewing experience with its 6.3inch FHD plus display. It renders lifelike images, so be it a high-octane sporting event or a gripping movie, you can enjoy varied content to your heart’s content. With high resolution and dynamic AMOLED display, you are all but set to view the engaging action unfold in front of your eyes.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://nowiamupdated.com/wp-content/uploads/2019/08/Samsung-Galaxy-Note-11.jpg",
                        InStock = true,
                        IsPreferredMobile = false,
                        ImageThumbnailUrl = "https://nowiamupdated.com/wp-content/uploads/2019/08/Samsung-Galaxy-Note-11.jpg"
                    }
                };
            }
        }
        public IEnumerable<Mobile> PreferredMobiles { get; }
        public Mobile GetMobileById(int MobileId)
        {
            throw new NotImplementedException();
        }
    }
}
