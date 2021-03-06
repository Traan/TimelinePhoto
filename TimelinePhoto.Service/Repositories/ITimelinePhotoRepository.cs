﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimelinePhoto.Service.DomainModels;

namespace TimelinePhoto.Service.Repositories
{
    public interface ITimelinePhotoRepository
    {
        IEnumerable<Entry> GetEntries();
        byte[] GetImageData(string id, string thumb);
    }
}
