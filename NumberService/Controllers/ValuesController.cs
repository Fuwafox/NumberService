using Microsoft.AspNetCore.Mvc;
using NumberService.Logic;


namespace NumberService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        Service service;
        public ValuesController(Service service) => this.service = service;


        [HttpGet]
        public long[] Get(long num)
        {
            service.Buffer.PushBack(num);
            return service.Buffer.ToArray();
        }
    }
}
