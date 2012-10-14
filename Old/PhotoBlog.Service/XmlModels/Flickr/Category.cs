using System.Xml.Serialization;

namespace TimelinePhotoOLD.Service.XmlModels.Flickr
{
    [System.SerializableAttribute]
    [XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false, ElementName = "category")]
    public class Category
    {
        private string schemeField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(AttributeName = "scheme")]
        public string Scheme
        {
            get
            {
                return this.schemeField;
            }
            set
            {
                this.schemeField = value;
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
