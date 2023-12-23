using CSharp_DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_DependencyInjection.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DepInjServicesController(
        GuidServiceOne serviceOne, 
        GuidServiceTwo serviceTwo
        ) : Controller
    {
        [HttpGet]
        [Route("/guid")]
        public ActionResult<List<string>> GetGuidCaseOne()
        {
            List<string> strs = [];
            strs.AddRange(serviceOne.GetGuid());
            strs.Add(" ");
            strs.AddRange(serviceTwo.GetGuid());
            return Json(strs);
        }

    }
}
