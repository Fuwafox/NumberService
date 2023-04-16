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
        public List<long> Get(long num)
        {
            service.Buffer.Insert(num);
            return service.Buffer.ToList();
        }
    }
}
