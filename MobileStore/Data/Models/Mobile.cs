using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class Mobile
    {
        [Key]
        public int MobileId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Specification { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredMobile { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Review> Reviews { get; set; }

        //[ForeignKey("Review")]
       // public int ReviewId { get; set; }
    }
    public class CommentModel {
       public int ReviewId { get; set; }
       public  int CommentID { get; set; }
       public string Comment { get; set; }
       public string CommentedBy { get; set; }
    }
}
