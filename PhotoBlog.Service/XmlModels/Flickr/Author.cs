using System;
using System.Xml.Serialization;

namespace PhotoBlog.Service.XmlModels.Flickr
{
    public class Author
    {
        private string profileField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:flickr:user", AttributeName = "profile")]
        public string Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
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
