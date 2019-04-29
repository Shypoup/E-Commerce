using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IA_PM.Models
{
    public class adminPage
    {
        public IEnumerable<user> allusers { get; set; }
        public IEnumerable<project> projects { get; set; }
        public user admin { get; set; }
        public project project { get; set; }

    }
}