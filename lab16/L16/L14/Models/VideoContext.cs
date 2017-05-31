using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L14.Models
{
    public class VideoContext:DbContext
    {
        public DbSet<VideoModel> VideoModels { get; set; }
    }
}