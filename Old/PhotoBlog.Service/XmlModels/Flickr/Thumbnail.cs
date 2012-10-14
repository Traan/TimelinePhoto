using System.Xml.Serialization;

namespace TimelinePhotoOLD.Service.XmlModels.Flickr
{
    [System.SerializableAttribute]
    [XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
    [XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false, ElementName = "thumbnail")]
    public class Thumbnail
    {
        private string urlField;

        private int heightField;

        private int widthField;

        /// <remarks/>
        [XmlAttribute(AttributeName = "url")]
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

        /// <remarks/>
        [XmlAttribute(AttributeName = "height")]
        public int Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute(AttributeName = "width")]
        public int Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }
}
