using System;
using System.Xml.Serialization;

namespace TimelinePhotoOLD.Service.XmlModels.Flickr
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    public class Image
    {
        private string urlField;

        private string titleField;

        private string linkField;

        [XmlElement(ElementName = "url")]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

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
    }
}
