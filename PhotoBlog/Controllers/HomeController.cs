using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoBlog.Models.Timeline;
using PhotoBlog.Service.Repositories;

namespace PhotoBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhotoBlogRepository _repository;

        public HomeController(IPhotoBlogRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Json()
        {
            var timeline = new Timeline();
            timeline.type = "default";

            var dates = new List<Date>();
            _repository.GetEntries().ToList()
                                    .ForEach(entry => dates.Add(new Date(entry: entry)));
            timeline.date = dates;
            return Json(new { timeline }, JsonRequestBehavior.AllowGet);
        }
    }
}
