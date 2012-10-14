using System.Xml.Serialization;

namespace TimelinePhoto.Service.XmlModels.Flickr
{
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false, ElementName = "credit")]
    public class Credit
    {
        private string roleField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(AttributeName = "role")]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
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
