using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L14.Models
{
    public class PhoneContext:DbContext
    {
        public DbSet<PhoneModel> PhoneModels { get; set; }
    }
}