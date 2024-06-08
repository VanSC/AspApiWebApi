using AspApiWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspApiWebApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class PearsonController : ControllerBase
    {
        [HttpGet(Name = "ListarPeople")]
        public IEnumerable<Pearson> getPeopleGet()
        {
            List<Pearson> listPeople = new List<Pearson>();

            for (int i = 0; i <= 100; i++)
            {
                listPeople.Add(new Pearson
                {
                    FirstName = "Nombre" + i,
                    LastName = "Apellido" + i
                });
            }

            return listPeople;
        }

        /*[HttpPost(Name = "ListarPeoplepost")]
        public List<Pearson> getPeoplePost()
        {
            List<Pearson> listPeople = new List<Pearson>();

            for (int i = 0; i <= 100; i++)
            {
                listPeople.Add(new Pearson 
                { 
                    FirstName="Nombre" + i, 
                    LastName="Apellido" + i
                });
            }

            return listPeople;
        }*/

        [HttpPost(Name = "ListarPeoplepost")] 
        public List<Pearson> getPeoplePost()
        {
            return null;
        }

    }
}
