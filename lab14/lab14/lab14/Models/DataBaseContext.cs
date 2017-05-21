using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab14.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}