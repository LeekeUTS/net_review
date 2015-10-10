using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace net_review.Models
{

    public class ReviewDbContext : DbContext{
        public ReviewDbContext()
            : base("DefaultConnection")
    {
    }
        public DbSet<Category> Category { get; set; }
        public DbSet<List> List { get; set; }
        public DbSet<Appendix> Appendix { get; set; }

    }

}