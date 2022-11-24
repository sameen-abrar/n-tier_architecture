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
    public class groupController : ApiController
    {
        [HttpGet]
        [Route("api/groups")]
        public HttpResponseMessage Get()
        {
            var data = groupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/groups/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = groupService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/groups/add")]
        public HttpResponseMessage Add(groupDTO obj)
        {
            var data = groupService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/groups/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = groupService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/groups/update")]
        public HttpResponseMessage update(groupDTO obj)
        {
            var data = groupService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
