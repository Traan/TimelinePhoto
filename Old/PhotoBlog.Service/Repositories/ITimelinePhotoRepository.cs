using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimelinePhotoOLD.Service.DomainModels;

namespace TimelinePhotoOLD.Service.Repositories
{
    public interface ITimelinePhotoRepository
    {
        IEnumerable<Entry> GetEntries();
    }
}
