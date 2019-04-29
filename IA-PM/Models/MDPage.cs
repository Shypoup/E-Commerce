using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IA_PM.Models
{
    public class MDPage
    {
        public IEnumerable<project> projects { get; set; }
        public user MD { get; set; }
        public project project { get; set; }

    }
}