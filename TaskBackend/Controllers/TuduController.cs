using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskBackend.Enum;
using TaskBackend.Models;
using TaskBackend.tuduService;

namespace TaskBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuduController : ControllerBase
    {
        private readonly TuduService _tuduService;

        public TuduController()
        {
            _tuduService = new TuduService();
        }

        [HttpGet("{id?}")]
        public IActionResult Tasks(int? id)
        {
            var mytudu = _tuduService.AllTUDU();
            if(id is null) return Ok (mytudu);

            mytudu = mytudu.Where(x => x.Id == id).ToList();
            return Ok(mytudu);
        }

       

    }
}
