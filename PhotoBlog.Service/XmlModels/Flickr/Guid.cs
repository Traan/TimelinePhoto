using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    public class Guid
    {
        private bool isPermaLinkField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(AttributeName = "isPermaLink")]
        public bool IsPermaLink
        {
            get
            {
                return this.isPermaLinkField;
            }
            set
            {
                this.isPermaLinkField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
