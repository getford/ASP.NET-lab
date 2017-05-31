using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;

namespace L14.Models
{
    public class VideoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        //public FileStream FileStream { get;  set; }

        public VideoModel() { }
        public  VideoModel(string title)
        {
            Title = title;
            
            //FileStream = new FileStream(@"E:\Work\ПИС\Проекты\16\L14\L14\Video\" + Id+Path.GetExtension(title), FileMode.Open, FileAccess.Read);
        }


    }
}
