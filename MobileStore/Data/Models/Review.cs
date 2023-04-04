using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int ParentId { get; set; }
        public string Content { get; set; }
        //[ForeignKey("User")]
        public string UserId { get; set; }
        //public virtual ApplicationIdentity User { get; set; }
        public string Username { get; set; }

        [ForeignKey("Mobile")]
        public int MobileId { get; set; }
        public int Rating { get; set; }
        public DateTime Sent { get; set; }
        public virtual Mobile Mobile { get; set; }
    }

    public class ReviewViewModel : Review
    {
        public int reviewId { get; set; }
        //public DateTime CommentDate { get; set; }
        public string strCommentDate { get {; return this.Sent.ToString("dd-MM-yyyy"); } }
    }
}
