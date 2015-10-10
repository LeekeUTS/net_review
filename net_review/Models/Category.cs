using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace net_review.Models
{
    public class Category
    {
        public int ID { get; set; }
        public String CategoryName { get; set; }
        public int ParentID { get; set; }
        public String Status { get; set; }
        public String Image { get; set; }
        public int Sort { get; set; }
        public String Note { get; set; }
        public String Appendix { get; set; }
    }
}