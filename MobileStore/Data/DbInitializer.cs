using MobileStore.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MobileStore.Data
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
             applicationBuilder.GetRequiredService<AppDbContext>();
            {
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Mobiles.Any())
                {
                    context.AddRange
                    (
                        new Mobile
                        {
                            Name = "XS Max",
                            Price = 13990L,
                            ShortDescription = "The Apple iPhone Xs Max delivers top-notch performance with the help of A12 Bionic chip.",
                            Specification = "Brand: Apple - Color: Gold - Operating System Type: IOS - Mobile Phone Type: Smartphone",
                            LongDescription = "The Apple iPhone Xs Max is armed with a leading-edge combination of the A12 Bionic chip and next-generation Neural Engine. It delivers a phenomenal performance, no matter if the phone is handling heavy computational tasks or everyday tasks.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/1565936397.33.jpg",
                            InStock = true,
                            IsPreferredMobile = true,
                            ImageThumbnailUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/1565936397.33.jpg"
                        },
                        new Mobile
                        {
                            Name = "IPhone 11",
                            Price = 11749L,
                            ShortDescription = "iPhone 11 smartphone is beautifully designed.",
                            Specification = "Brand: Apple - Color: Pink - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "This Apple iPhone 11 smartphone is beautifully designed, making you fall in love with it each time you see it. The 6.1inch Liquid Retina display captivates your attention, unlike any other smartphone. The glass and aerospace-grade aluminum design make it durable and lend it heart-stealing looks.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/78877_cbe0138e-899f-457b-b3a9-423b8fac2599.jpg",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://d28i4xct2kl5lp.cloudfront.net/product_images/78877_cbe0138e-899f-457b-b3a9-423b8fac2599.jpg"
                        },
                        new Mobile
                        {
                            Name = "XR ",
                            Price = 12.95M,
                            ShortDescription = "Apple Iphone XR With Face Time - 128 GB, 4G LTE, White, 3 GB Ram, Single Sim & E-Sim",
                            Specification = "Brand: Apple - Color: Baby Blue - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "The Apple iPhone XR features next-level innovation. With the well-engineered A12 Bionic chip integrated into this smartphone, it delivers an impressive performance.  In addition to it, this iPhone is also powered by the robust Neural engine that is programmed to render a high processing speed, allowing you to launch and run multiple applications simultaneously.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://i-cdn.phonearena.com/images/phones/73068-xlarge/Apple-iPhone-XR-2.jpg",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://i-cdn.phonearena.com/images/phones/73068-xlarge/Apple-iPhone-XR-2.jpg"
                        },
                        new Mobile
                        {
                            Name = "6S Plus ",
                            Price = 6700L,
                            ShortDescription = "Apple iPhone 6S Plus with FaceTime - 128GB, 4G LTE, Rose Gold",
                            Specification = "Brand: Apple - Color: Purple - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "Govern your life effectively and efficiently with the Apple iPhone 6s Plus. Various underlying technologies work in perfect unison to make this iPhone a device that performs tasks incredibly quickly. The iPhone 6s Plus redefines user experience, making doing things and living your life easier.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://th.bing.com/th/id/R.62a9494cee39dea3d069ffb4f5edf2df?rik=UggxSSIvLmBYkg&riu=http%3a%2f%2fimg.ebyrcdn.net%2f796505-723784-800.jpg&ehk=s%2bbYn%2bA1pgBPHLIy3S81HakKWUL6WgUo6BnqqcQruSU%3d&risl=&pid=ImgRaw&r=0",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/R.62a9494cee39dea3d069ffb4f5edf2df?rik=UggxSSIvLmBYkg&riu=http%3a%2f%2fimg.ebyrcdn.net%2f796505-723784-800.jpg&ehk=s%2bbYn%2bA1pgBPHLIy3S81HakKWUL6WgUo6BnqqcQruSU%3d&risl=&pid=ImgRaw&r=0"
                        },
                        new Mobile
                        {
                            Name = "Iphone 8",
                            Price = 9555L,
                            ShortDescription = "Apple Iphone 8 With Facetime - 64 GB, 4G LTE, Silver, 2 GB Ram, Single Sim",
                            Specification = "Brand: Apple - Color: White - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            Category = Categories["IPhone"],
                            LongDescription = "Apple iPhone 8 features a dual rear camera setup that clicks excellent pictures, any time of the day. This iPhone 8 looks appealing in a dazzling silver finish.The Apple iPhone 8 gives you a smooth user experience and rich entertainment.",
                            ImageUrl = "https://www.obchody24.cz/items/apple/smartphone-chytre-mobily/4173739/mobilni-telefon-apple-iphone-8-plus-64-gb-silver-1505539201-next-900px-808832.jpg",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://www.obchody24.cz/items/apple/smartphone-chytre-mobily/4173739/mobilni-telefon-apple-iphone-8-plus-64-gb-silver-1505539201-next-900px-808832.jpg"
                        },
                        new Mobile
                        {
                            Name = "Iphone 7",
                            Price = 6780L,
                            ShortDescription = "Apple Iphone 7 With Facetime - 256 GB, 4G LTE, Rose Gold, 2 GB Ram, Single Sim",
                            Specification = "Brand: Apple - Color: Purple - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "It's true that when you carry an iPhone 7 you need nothing else as it offers the best of everything. Right from a camera capable of capturing 4K videos to a high definition retina display, the iPhone 7 rose gold gives you the best hardware and software to enhance your productivity and unleash your creativity.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://www.obchody24.cz/items/apple/smartphone-chytre-mobily/3714742/mobilni-telefon-apple-iphone-7-plus-256-gb-rose-gold-1473916801-next-900px-702586.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://www.obchody24.cz/items/apple/smartphone-chytre-mobily/3714742/mobilni-telefon-apple-iphone-7-plus-256-gb-rose-gold-1473916801-next-900px-702586.jpg"
                        },
                        new Mobile
                        {
                            Name = "iPhone SE",
                            Price = 9500L,
                            ShortDescription = "Apple iPhone SE smartphone",
                            Specification = "Brand: Apple - Color: White&Black - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "iPhone SE packs our powerful A13 Bionic chip into our most popular size at our most affordable price. It’s just what you’ve been waiting for.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.Z6bDKOpBn_RcTyo0L36XhgHaHa?pid=ImgDet&rs=1",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.Z6bDKOpBn_RcTyo0L36XhgHaHa?pid=ImgDet&rs=1"
                        },
                        new Mobile
                        {
                            Name = "iPhone 11 Pro",
                            Price = 12449L,
                            ShortDescription = "Apple iPhone 11 with FaceTime - 128GB, 4GB RAM, 4G LTE, Purple, Single SIM & E-SIM",
                            Specification = "Brand: Apple - Color: Silver - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = " Apple iPhone 11 delivers a smooth and seamless performance. This 4GB RAM Apple phone has the technologies and components to handle complex tasks effortlessly. The advanced 12MP camera setup allows you to click high-quality pictures and shoot realistic videos. ",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.S6v7d93y5VCtUlChPPlfJgHaKF?pid=ImgDet&rs=1",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.S6v7d93y5VCtUlChPPlfJgHaKF?pid=ImgDet&rs=1"
                        },
                        new Mobile
                        {
                            Name = "iPhone 12 ",
                            Price = 13299L,
                            ShortDescription = "Apple iPhone 12 Mini, 5.4-inch, 64 GB, 4 GB RAM - Purple",
                            Specification = "Brand: Apple - Color: Violet - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "Features: HDR video support, Oleophobic coating, Scratch-resistant glass (Ceramic Shield), Ambient light sensor, Proximity sensor",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71R1w6Y9kXS._AC_SX679_.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/71R1w6Y9kXS._AC_SX679_.jpg"
                        },
                        new Mobile
                        {
                            Name = "iPhone 11 Pro",
                            Price = 16699L,
                            ShortDescription = "Apple iPhone 11 Pro with FaceTime - 64GB, 4GB RAM, 4G LTE, Silver, Single SIM & E-SIM",
                            Specification = "Brand: Apple - Color: Silver - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "The Apple iPhone 11 Pro offers the ideal way of making your leisure time entertaining and fun. It sports a large 5.8inch Super Retina XDR display that delivers impressive picture quality so that you can watch your favorite content and play games on it. ",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://www.matwaffar.com/wp-content/uploads/thumbs_dir/apple-iphone-11-pro-with-facetime-256gb-4gb-ram-4g-lte-silver-single-2-1-ox905me1q7b3j0ynsonelbw7qec6t6j2xkfksh57y6.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://www.matwaffar.com/wp-content/uploads/thumbs_dir/apple-iphone-11-pro-with-facetime-256gb-4gb-ram-4g-lte-silver-single-2-1-ox905me1q7b3j0ynsonelbw7qec6t6j2xkfksh57y6.jpg"
                        },
                        new Mobile
                        {
                            Name = "Phone 12 Pro",
                            Price = 19555L,
                            ShortDescription = "Apple iPhone 12 Pro 128GB 6 GB RAM, Pacific Blue",
                            Specification = "Brand: Apple - Color: Dark Green - Operating System Type: IOs - Mobile Phone Type: Smartphone",
                            LongDescription = "iPhone 12 Pro. Super Retina XDR display. 6.1‑inch (diagonal) all‑screen OLED display. 2532‑by‑1170-pixel resolution at 460 ppi. The iPhone 12 Pro display has rounded corners that follow a beautiful curved design, and these corners are within a standard rectangle.",
                            Category = Categories["IPhone"],
                            ImageUrl = "https://www.matwaffar.com/wp-content/uploads/2020/11/apple-iphone12-pro-128gb-6-gb-ram-pacificblue-1.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://www.matwaffar.com/wp-content/uploads/2020/11/apple-iphone12-pro-128gb-6-gb-ram-pacificblue-1.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung 9 ",
                            Price = 11600L,
                            ShortDescription = "The Samsung Galaxy Note 9 smartphone marks the evolution of mobile technology.",
                            Specification = "Brand: Samsung - Color: gradient - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "The Samsung Galaxy smartphone is powered by a mighty 10nm Octa-core application processor, which is programmed to enhance the performance and consume minimal power for smooth functioning. A 6GB RAM further bolsters the processing speed for a lag-free performance, allowing you to multitask seamlessly.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://www.androidguys.com/wp-content/uploads/2019/08/Note10_Auraglow1.jpg",
                            InStock = true,
                            IsPreferredMobile = true,
                            ImageThumbnailUrl = "https://www.androidguys.com/wp-content/uploads/2019/08/Note10_Auraglow1.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy A02 ",
                            Price = 1735L,
                            ShortDescription = " Samsung Galaxy A02 Dual Sim Mobile, 6.5 Inches, 32 GB, 3 GB RAM, 4G LTE - Gray ",
                            Specification = "Brand: Samsung - Color: Black - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "Samsung Galaxy A02 Dual Sim Mobile, 6.5 Inches, 32 GB, 3 GB RAM, 4G LTE - Gray. The A02 delivers a dual rear camera system that consists of a 13MP wide-angle lens for capturing more of what you see in a single image, and a 2MP macro lens for close-up shots with fine detail.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://specifications-pro.com/wp-content/uploads/2021/01/Samsung-Galaxy-A02.jpg",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://specifications-pro.com/wp-content/uploads/2021/01/Samsung-Galaxy-A02.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy M11 ",
                            Price = 2250L,
                            ShortDescription = "Samsung Galaxy M11 Dual SIM - 32GB, 3GB RAM, 4G LTE - Violet",
                            Specification = "Brand: Samsung - Color: Black - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "Samsung Galaxy M11 Dual-SIM Smartphone. It has an elegant design that boasts smooth curves that never fail to turn heads. The 6.4inch HD Plus Infinity-O Display provides an enhanced view of your favorite video or gaming content without missing out on details.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://www.dekhnews.com/wp-content/uploads/2020/09/MP000000007060530_437Wx649H_20200606161616.jpeg",
                            InStock = true,
                            IsPreferredMobile = true,
                            ImageThumbnailUrl = "https://www.dekhnews.com/wp-content/uploads/2020/09/MP000000007060530_437Wx649H_20200606161616.jpeg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy M32",
                            Price = 4449L,
                            ShortDescription = "Samsung Galaxy M32 Dual SIM - 6.4 Inche, 128 GB, 6 GB RAM, 4G LTE",
                            Specification = "Brand: Samsung - Color: White - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "The Galaxy M32 has a smooth, yet patterned surface with slight lines that catch the prism light beautifully at various angles. With a choice of black or blue, the design is balanced and sturdy.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://images.yaoota.com/gOFT_Q3oA1nz3aA4WmIjH3OLabQ=/trim/yaootaweb-production/media/crawledproductimages/e73ad4efd4bb317a84e0d593441973598987559b.jpg",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://images.yaoota.com/gOFT_Q3oA1nz3aA4WmIjH3OLabQ=/trim/yaootaweb-production/media/crawledproductimages/e73ad4efd4bb317a84e0d593441973598987559b.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy A32",
                            Price = 3860L,
                            ShortDescription = "Samsung Galaxy A32 Dual SIM - 6.4 Inches, 6GB RAM, 128GB, 4G LTE - Blue",
                            Specification = "Brand: Samsung - Color: Blue - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "Samsung Galaxy A32 5G review: Cameras. The Galaxy A32 5G employs four cameras: the 48MP main camera, an 8MP ultrawide shooter, a 5MP macro lens, and a 2MP depth sensor.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://www.techidence.com/wp-content/uploads/2021/01/Samsung-Galaxy-A32-5G.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://www.techidence.com/wp-content/uploads/2021/01/Samsung-Galaxy-A32-5G.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy A72 ",
                            Price = 6669L,
                            ShortDescription = "Samsung Galaxy A72 Dual SIM - 6.7 Inches, 8 GB RAM, 128 GB - Blue",
                            Specification = "Brand: Samsung - Color: Black - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "The Galaxy A72 on-screen fingerprint sensor recognizes your unique fingerprint, allowing you an easy and secure way to unlock your phone. And with Samsung Pass biometric authentication services, your fingerprint provides a faster, safer authentication method for app and website login.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://www.lowyat.net/wp-content/uploads/2021/02/Samsung-Galaxy-A72-Design-Specifications-Leaks-1.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://www.lowyat.net/wp-content/uploads/2021/02/Samsung-Galaxy-A72-Design-Specifications-Leaks-1.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy M12",
                            Price = 2649L,
                            ShortDescription = "Samsung Galaxy M12 Dual SIM Mobile - 6.5 inches, 4GB RAM, 64GB - Blue",
                            Specification = "Brand: Samsung - Color: Baby Blue - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "Samsung Galaxy M12 review: Design and Build Quality. Let’s talk about the Galaxy M12 aesthetics first. Like most Samsung phones, the Galaxy M12 has an appealing design. It has a smudge-resistant, dual-tone finish on the back panel. The major portion is covered in fine vertical lines followed by a plain matte finish with Samsung logo etched on it.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://priceinsouthafrica.com/wp-content/uploads/2021/02/Samsung-Galaxy-M12.jpg",
                            InStock = false,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://priceinsouthafrica.com/wp-content/uploads/2021/02/Samsung-Galaxy-M12.jpg"
                        },
                        new Mobile
                        {
                            Name = "Samsung Galaxy Note 10",
                            Price = 13410L,
                            ShortDescription = "The Samsung Galaxy Note 10 Dual-SIM smartphone keeps you abreast with the pace of modern-day mobile computing.",
                            Specification = "Brand: Samsung - Color: Gardient - Operating System Type: Android - Mobile Phone Type: Smartphone",
                            LongDescription = "This Samsung Galaxy Note 10 smartphone provides a hair-raising viewing experience with its 6.3inch FHD plus display. It renders lifelike images, so be it a high-octane sporting event or a gripping movie, you can enjoy varied content to your heart’s content. With high resolution and dynamic AMOLED display, you are all but set to view the engaging action unfold in front of your eyes.",
                            Category = Categories["Samsung"],
                            ImageUrl = "https://nowiamupdated.com/wp-content/uploads/2019/08/Samsung-Galaxy-Note-11.jpg",
                            InStock = true,
                            IsPreferredMobile = false,
                            ImageThumbnailUrl = "https://nowiamupdated.com/wp-content/uploads/2019/08/Samsung-Galaxy-Note-11.jpg"
                        }
                    );
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "IPhone", Description="All IPhone mobiles" },
                        new Category { CategoryName = "Samsung", Description="All Samsung mobiles" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
