using Microsoft.AspNetCore.Mvc;
using NumberService.Logic;

namespace NumberService.Controllers
{
   
    /// <summary>
    /// Апи контроллер
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Класс с логикой хранения добавления данных
        /// </summary>
        private readonly Service _service;
        /// <summary>
        /// Поле для логирования
        /// </summary>
 
        private ILogger<ValuesController> _logger;
        /// <summary>
        /// Конструктор контроллера
        /// </summary>
        /// <param name="service"></param>
        /// <param name="logger"></param>

        public ValuesController(Service service, ILogger<ValuesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Метод  - запрос для добавления и вывода данных
        /// </summary>
        /// <param name="num">число для добавления в массив</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public ActionResult<int[]> Get(int num)
        {
            try
            {
                _service.Add(num);
                return _service.Select();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, message: "Ошибка при добавлении или выводе данных");
                return StatusCode(StatusCodes.Status500InternalServerError, value: "Ошибка при добавлении или выводе данных");
            }
        }
    }
}
