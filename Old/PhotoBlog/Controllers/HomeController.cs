﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimelinePhotoOLD.Models.Timeline;
using TimelinePhotoOLD.Service.Repositories;

namespace TimelinePhotoOLD.Controllers
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
