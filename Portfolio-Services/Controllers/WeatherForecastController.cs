using Microsoft.AspNetCore.Mvc;
using Portfolio_Services.Services;

namespace Portfolio_Services.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private  IContentService contentService;

            public WeatherForecastController(IContentService contentService)
            { 
                this.contentService = contentService;
        
            }
            
       
        [HttpGet(Name = "get-dummy-text")]
        public ActionResult<String> GetDummyText()
        {

            return Ok(this.contentService.getDummyText());
           
        }
    }
}
