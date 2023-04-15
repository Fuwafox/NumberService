using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NumberService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        static long x;
        
        [HttpGet]
        public long Get( long num) 
        {
            Thread thread = new Thread(() => { x = num; });
            thread.Start();
            return x;
        }


    }
}
