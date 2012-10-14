using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimelinePhoto.Models.Timeline;
using TimelinePhoto.Service.Repositories;

namespace TimelinePhoto.Controllers
{
    public class PhotoController : ApiController
    {
        private readonly ITimelinePhotoRepository _repository;

        public PhotoController(ITimelinePhotoRepository repository)
        {
            _repository = repository;
        }

        // GET api/photo
        public Timeline Get()
        {
            var timeline = new Timeline { Type = "default" };

            var dates = new List<Date>();
            _repository.GetEntries().ToList()
                                    .ForEach(entry => dates.Add(new Date(entry: entry)));
            timeline.Dates = dates;
            return timeline;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}