using System;

namespace TimelinePhoto.Models.Timeline
{
    public class Asset
    {
        public Uri media { get; set; }

        public string credit { get; set; }

        public string caption { get; set; }

        public string type { get; set; }

        public Asset(Service.DomainModels.Asset assset)
        {
            media = assset.Media;
            credit = assset.Credit;
            caption = assset.Caption;
            type = assset.Type;
        }
    }
}