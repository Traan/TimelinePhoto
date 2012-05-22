using System;
using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "rss")]
    public class Rss
    {
        private Channel channelField;

        private decimal versionField;

        [XmlElement(ElementName = "channel")]
        public Channel Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute(AttributeName = "version")]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
}
