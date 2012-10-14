using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimelinePhotoOLD.Models.Timeline;
using TimelinePhotoOLD.Service.Repositories;

namespace TimelinePhotoOLD.Controllers
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
            var timeline = new Timeline { type = "default" };

            var dates = new List<Date>();
            _repository.GetEntries().ToList()
                                    .ForEach(entry => dates.Add(new Date(entry: entry)));
            timeline.date = dates;
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