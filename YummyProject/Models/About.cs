using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class About
    {
        //[Key] Primary KEy Id yerine farklı bir şey kullanılırsa
        public int AboutId { get; set; }
        public string ImagerUrl { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string PhoneNumber { get; set; }
    }
}