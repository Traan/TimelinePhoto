﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoBlog.Service.DomainModels
{
    public class Asset
    {
        public Uri Media { get; set; }

        public string Credit { get; set; }

        public string Caption { get; set; }

        public string Type { get; set; }
    }
}
