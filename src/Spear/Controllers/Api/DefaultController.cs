using Microsoft.AspNetCore.Mvc;

namespace Spear.Controllers.Api
{
    [ApiController]
    [Route("api/")]
    public class DefaultController
    {
        [HttpGet]
        public string Get()
        {
            return DateTimeOffset.Now.ToString(); 
        }

    }
}
