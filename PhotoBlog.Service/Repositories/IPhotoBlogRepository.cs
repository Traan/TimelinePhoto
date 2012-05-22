using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhotoBlog.Service.DomainModels;

namespace PhotoBlog.Service.Repositories
{
    public interface IPhotoBlogRepository
    {
        IEnumerable<Entry> GetEntries();
    }
}
