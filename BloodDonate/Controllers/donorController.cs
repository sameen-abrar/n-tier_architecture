using BLL.DTO;
using BLL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodDonate.Controllers
{
    public class donorController : ApiController
    {
        [HttpGet]
        [Route("api/donors")]
        public HttpResponseMessage Get()
        {
            var data = donorService.Get();
            var group = groupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/donors/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = donorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/donors/add")]
        public HttpResponseMessage Add(donorDTO obj)
        {
            var data = donorService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/donors/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = donorService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/donors/update")]
        public HttpResponseMessage update(donorDTO obj)
        {
            var data = donorService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
