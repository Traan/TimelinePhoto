using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimelinePhoto.Models.Timeline;
using TimelinePhoto.Service.Repositories;

namespace TimelinePhoto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITimelinePhotoRepository _repository;

        public HomeController(ITimelinePhotoRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
