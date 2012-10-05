using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimelinePhoto.Service.DomainModels
{
    public class Entry
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; }

        public Asset Asset { get; set; }
    }
}
