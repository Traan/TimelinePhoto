using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    public class Feed : SyndicationFeed
    {
        //public IEnumerable<Item> FlickrItems
        //{
        //    get
        //    {
        //        return this.Items.Cast<Item>();
        //    }
        //}

        protected override SyndicationItem CreateItem()
        {
            return new Item();
        }
    }
}
