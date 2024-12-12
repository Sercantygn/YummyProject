using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class ContanctInfo
    {
        public int ContactInfoId { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string MapUrl { get; set; }
        public string OpenHours { get; set; }
    }
}