using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Tarteeb.Auth.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok("Auth microservice is up and running!");
    }
}
