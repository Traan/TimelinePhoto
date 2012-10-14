using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TimelinePhoto.Service.Repositories;

namespace TimelinePhoto
{
    /// <summary>
    /// Summary description for Image
    /// </summary>
    public class Image : IHttpHandler
    {
        private readonly ITimelinePhotoRepository _repository;

        public Image() 
        {
            _repository = GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(ITimelinePhotoRepository)) as ITimelinePhotoRepository;
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(_repository.GetImageData(context.Request.QueryString["id"]));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}