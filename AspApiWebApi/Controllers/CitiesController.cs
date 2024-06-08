using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspApiWebApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        

        [HttpGet(Name = "Listar")]
        public List<String> Listar()
        {
            List<String> list = new List<String>();
            list.Add("London");
            list.Add("Paris");
            return list;
        }

        [HttpGet(Name = "getCities2")] //nombre del método
        public List<String> Get2() //nombre dl endpoint
        {
            List<String> list = new List<String>();
            list.Add("London");
            return list;
        }
    }
}
