using System;
using System.Runtime.Serialization;

namespace TimelinePhoto.Models.Timeline
{
    [DataContract]
    public class Asset
    {
        [DataMember(Name="media")]
        public Uri Media { get; set; }

        [DataMember(Name="credit")]
        public string Credit { get; set; }

        [DataMember(Name="caption")]
        public string Caption { get; set; }

        [DataMember(Name="type")]
        public string Type { get; set; }

        [DataMember(Name = "thumbnail")]
        public Uri Thumbnail { get; set; }

        public Asset(Service.DomainModels.Asset assset)
        {
            Media = assset.Media;
            Credit = assset.Credit;
            Caption = assset.Caption;
            Type = assset.Type;
            Thumbnail = assset.Thumbnail;
        }
    }
}