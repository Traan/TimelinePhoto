using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoBlog.Models.Timeline
{
    public class Timeline
    {
        public string headline { get; set; }

        public string type { get; set; }

        public string startDate { get; set; }

        public string text { get; set; }

        public IEnumerable<Date> date { get; set; }
    }
}