using TimelinePhotoOLD.Service.DomainModels;

namespace TimelinePhotoOLD.Models.Timeline
{
    public class Date
    {
        public string startDate { get; set; }

        public string headline { get; set; }

        public string text { get; set; }

        public Asset asset { get; set; }

        public Date(Entry entry)
        {
            startDate = entry.Date.ToString("yyyy,M,d");
            headline = entry.Title;
            text = entry.Text;
            asset = new Asset(entry.Asset);
        }
    }
}