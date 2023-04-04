using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string AccountNo { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int AdminId { get; set; }
        public virtual ICollection<Mobile> Mobile { get; set; }
        public virtual ICollection<Promotion> promotions { get; set; }
    }
}
