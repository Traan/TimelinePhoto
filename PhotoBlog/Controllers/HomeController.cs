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
    }
}
