using System.Runtime.Serialization;
using TimelinePhoto.Service.DomainModels;

namespace TimelinePhoto.Models.Timeline
{
    [DataContract]
    public class Date
    {
        [DataMember(Name="startDate")]
        public string StartDate { get; set; }

        [DataMember(Name="headline")]
        public string Headline { get; set; }

        [DataMember(Name="text")]
        public string Text { get; set; }

        [DataMember(Name="asset")]
        public Asset Asset { get; set; }

        public Date(Entry entry)
        {
            StartDate = entry.Date.ToString("yyyy,M,d");
            Headline = entry.Title;
            Text = entry.Text;
            Asset = new Asset(entry.Asset);
        }
    }
}