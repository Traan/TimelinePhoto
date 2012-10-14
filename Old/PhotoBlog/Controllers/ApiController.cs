using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimelinePhoto.Models.Timeline;
using TimelinePhoto.Service.Repositories;

namespace TimelinePhoto.Controllers
{
    public class ApiController : Controller
    {
        private readonly ITimelinePhotoRepository _repository;

        public ApiController(ITimelinePhotoRepository repository)
        {
            _repository = repository;
        }

        public JsonResult GetEntries()
        {
            var timeline = new Timeline { type = "default" };

            var dates = new List<Date>();
            _repository.GetEntries().ToList()
                                    .ForEach(entry => dates.Add(new Date(entry: entry)));
            timeline.date = dates;
            return Json(new { timeline }, JsonRequestBehavior.AllowGet);
        }
    }
}
