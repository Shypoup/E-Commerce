using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IA_PM.Models
{
    public class homePage
    {
        public IEnumerable<project> projects { get; set; }
        public project project { get; set; }
    }
}