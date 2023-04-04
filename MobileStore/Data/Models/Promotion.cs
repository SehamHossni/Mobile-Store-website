using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class Promotion
    {
        [Key]
        public int PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime Starten { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PromotionDate { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal OverAlllDiscountPrice { get; set; }
        public string ZipCode { get; set; }
        public string PromotionType { get; set; }

        [ForeignKey("MobileId")]
        public int MobileId { get; set; }
        public virtual Mobile mobiles { get; set; }
        public virtual ICollection<Supplier> suppliers { get; set; }
    }
}
