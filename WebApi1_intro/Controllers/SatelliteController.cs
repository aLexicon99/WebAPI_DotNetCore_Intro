using Microsoft.AspNetCore.Mvc;
using WebApi1_intro.Models;

namespace WebApi1_intro.Controllers
{
    [ApiController]
    [Route("[controller]")] // https://localhost:7266/satellite
    public class SatelliteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "This is the response from the Satellite Index 'action'";
        }

        [HttpGet]
        [Route("json")]
        public ActionResult<object> GetSimpleJson(string id)
        {
            return Ok(new { message = "Hello", status = "success", id });
        }

        [HttpGet]
        [Route("satdetails")]
        public ActionResult<Satellite> Details(int Id)
        {
            Satellite S = new Satellite()
            {
                Id = Id,
                Model = "XYZ123",
                MaxHeight = 200
            };
            return S;
        }
    }
}
