using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    public class Item : SyndicationItem
    {
        public DateTime DateTaken
        {
            get
            {
                return this.ElementExtensions.ReadElementExtensions<DateTime>("date.Taken", "http://purl.org/dc/elements/1.1/").FirstOrDefault();
            }
        }

        public Description Description
        {
            get
            {
                var serializer = new XmlSerializer(type: typeof (Description));
                return this.ElementExtensions.ReadElementExtensions<Description>(extensionName: "description", 
                                                                                 extensionNamespace: "http://search.yahoo.com/mrss/", 
                                                                                 serializer: serializer).FirstOrDefault();
            }
        }

        public new Content Content
        {
            get
            {
                var serializer = new XmlSerializer(type: typeof (Content));
                return this.ElementExtensions.ReadElementExtensions<Content>(extensionName: "content", 
                                                                             extensionNamespace: "http://search.yahoo.com/mrss/", 
                                                                             serializer: serializer).FirstOrDefault();
            }
        }

        public new string Title
        {
            get
            {
                return this.ElementExtensions.ReadElementExtensions<string>(extensionName: "title", 
                                                                            extensionNamespace: "http://search.yahoo.com/mrss/").FirstOrDefault();
            }
        }

        public Thumbnail Thumbnail
        {
            get
            {
                var serializer = new XmlSerializer(type: typeof (Thumbnail));
                return this.ElementExtensions.ReadElementExtensions<Thumbnail>(extensionName: "thumbnail", 
                                                                               extensionNamespace: "http://search.yahoo.com/mrss/", 
                                                                               serializer: serializer).FirstOrDefault();
            }
        }

        public Credit Credit
        {
            get
            {
                var serializer = new XmlSerializer(type: typeof(Credit));
                return this.ElementExtensions.ReadElementExtensions<Credit>(extensionName: "credit", 
                                                                            extensionNamespace: "http://search.yahoo.com/mrss/", 
                                                                            serializer: serializer).FirstOrDefault();
            }
        }

        public Category Category
        {
            get
            {
                var serializer = new XmlSerializer(type: typeof (Category));
                return this.ElementExtensions.ReadElementExtensions<Category>(extensionName: "category", 
                                                                              extensionNamespace: "http://search.yahoo.com/mrss/", 
                                                                              serializer: serializer).FirstOrDefault();
            }
        }
    }
}
