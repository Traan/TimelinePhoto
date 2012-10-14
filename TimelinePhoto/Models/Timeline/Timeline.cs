using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TimelinePhoto.Models.Timeline
{
    [DataContract]
    public class Timeline
    {
        [DataMember(Name="headline")]
        public string Headline { get; set; }

        [DataMember(Name="type")]
        public string Type { get; set; }

        [DataMember(Name="startDate")]
        public string StartDate { get; set; }

        [DataMember(Name="text")]
        public string Text { get; set; }

        [DataMember(Name="date")]
        public IEnumerable<Date> Dates { get; set; }
    }
}