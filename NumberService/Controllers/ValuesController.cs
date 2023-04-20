using Microsoft.AspNetCore.Mvc;
using NumberService.Logic;


namespace NumberService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        Service _service;
        public ValuesController(Service service) =>
         this._service = service;


        [HttpGet]
        public int[] Get(int num)
        {
            _service.Insert(num);
            return _service.BufferS.ToArray();
        }
    }
}
