using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IA_PM.Models
{
    public class CustomerPage
    {
        public IEnumerable<project> projects { get; set; }
        public IEnumerable<user> users { get; set; }
        public user customer { get; set; }
        public project project { get; set; }
    }
}