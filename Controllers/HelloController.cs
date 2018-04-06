using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace asp.net_basic.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("template/{Name}")]
        public string Method(string Name)
        {
            return $"Hello {Name}";
        }

        [HttpGet]
        [Route("display/{first_name}/{last_name}/{number}/{color}")]
        public JsonResult Display(string first_name, string last_name, int number, string color)
        {
            var AnonObject = new {
                                FirstName = $"{first_name}",
                                LastName = $"{last_name}",
                                Age = number,
                                Color = $"{color}"
                            };
            return Json(AnonObject);
        }
    }
}
