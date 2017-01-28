using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebsiteService.Data
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext() : base("name=default")
        {

        }

        public DbSet<WebsiteDomain.User> Users { get; set; }
    }
}