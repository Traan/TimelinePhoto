using System;
using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    public class Item
    {
        private string titleField;

        private string linkField;

        private string descriptionField;

        private DateTimeOffset pubDateField;

        private DateTime dateTakenField;

        private Author authorField;

        private Guid guidField;

        private Content mediaContentField;

        private string mediaTitleField;

        private Description mediaDescriptionField;

        private Thumbnail mediaThumbnailField;

        private Credit mediaCreditField;

        private Category mediaCategoryField;

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
        public DateTimeOffset PubDate
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

        [XmlElement("date.Taken", Namespace = "http://purl.org/dc/elements/1.1/")]
        public DateTime DateTaken
        {
            get
            {
                return this.dateTakenField;
            }
            set
            {
                this.dateTakenField = value;
            }
        }

        [XmlElement(ElementName = "author")]
        public Author Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        [XmlElement(ElementName = "guid")]
        public Guid Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }

        [XmlElement(ElementName = "content", Namespace = "http://search.yahoo.com/mrss/")]
        public Content MediaContent
        {
            get
            {
                return this.mediaContentField;
            }
            set
            {
                this.mediaContentField = value;
            }
        }

        /// <remarks/>
        [XmlElement(ElementName = "title", Namespace = "http://search.yahoo.com/mrss/")]
        public string MediaTitle
        {
            get
            {
                return this.mediaTitleField;
            }
            set
            {
                this.mediaTitleField = value;
            }
        }

        /// <remarks/>
        [XmlElement(ElementName = "description", Namespace = "http://search.yahoo.com/mrss/")]
        public Description MediaDescription
        {
            get
            {
                return this.mediaDescriptionField;
            }
            set
            {
                this.mediaDescriptionField = value;
            }
        }

        /// <remarks/>
        [XmlElement(ElementName = "thumbnail", Namespace = "http://search.yahoo.com/mrss/")]
        public Thumbnail MediaThumbnail
        {
            get
            {
                return this.mediaThumbnailField;
            }
            set
            {
                this.mediaThumbnailField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(ElementName = "credit", Namespace = "http://search.yahoo.com/mrss/")]
        public Credit MediaCredit
        {
            get
            {
                return this.mediaCreditField;
            }
            set
            {
                this.mediaCreditField = value;
            }
        }

        /// <remarks/>
        [XmlElement(ElementName = "category", Namespace = "http://search.yahoo.com/mrss/")]
        public Category MediaCategory
        {
            get
            {
                return this.mediaCategoryField;
            }
            set
            {
                this.mediaCategoryField = value;
            }
        }
    }
}
