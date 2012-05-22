using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    [XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false, ElementName = "description")]
    public class Description
    {
        private string typeField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(AttributeName = "type")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
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
