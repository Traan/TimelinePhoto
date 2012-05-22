using System;
using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    public class Channel
    {
        private string titleField;

        private string linkField;

        private string descriptionField;

        private DateTimeOffset pubDateField;

        private DateTimeOffset lastBuildDateField;

        private string generatorField;

        private Image imageField;

        private Item[] itemField;

        [XmlElement(ElementName = "title")]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        [XmlElement(ElementName = "link")]
        public string Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        [XmlElement(ElementName = "description")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        [XmlElement(ElementName = "pubDate")]
        public DateTimeOffset pubDate
        {
            get
            {
                return this.pubDateField;
            }
            set
            {
                this.pubDateField = value;
            }
        }

        [XmlElement(ElementName = "lastBuildDate")]
        public DateTimeOffset LastBuildDate
        {
            get
            {
                return this.lastBuildDateField;
            }
            set
            {
                this.lastBuildDateField = value;
            }
        }

        [XmlElement(ElementName = "generator")]
        public string Generator
        {
            get
            {
                return this.generatorField;
            }
            set
            {
                this.generatorField = value;
            }
        }

        [XmlElement(ElementName = "image")]
        public Image Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        [XmlElement(ElementName = "item")]
        public Item[] Items
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
