using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class Form
    {
        public string subject { get; set; }
        public DateTime startTime { get; set; }

        public DateTime examDate { get; set; }

        public int duration { get; set; }

        public string classroom { get; set; }

        public string faculty { get; set; }
    }
}