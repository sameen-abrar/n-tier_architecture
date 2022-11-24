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
    public class userController : ApiController
    {
        [HttpGet]
        [Route("api/users")]
        public HttpResponseMessage Get()
        {
            var data = userService.Get();
            var group = groupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/users/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = userService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/users/add")]
        public HttpResponseMessage Add(userDTO obj)
        {
            var data = userService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/users/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = userService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/users/update")]
        public HttpResponseMessage update(userDTO obj)
        {
            var data = userService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
