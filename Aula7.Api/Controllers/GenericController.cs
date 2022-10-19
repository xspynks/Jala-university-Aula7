using Aula7.Api.Models;
using Aula7.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Aula7.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GenericController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetUserById(int id)
        {
            var repo = new UserRepository();
            var user = repo.GetById(id);

            return Ok(user);
        }


        [HttpGet()]
        public IActionResult GetManagerById(int id)
        {
            var repo = new ManagerRepository();
            var manager = repo.GetById(id);

            return Ok(manager);
        }

        [HttpPost]
        public IActionResult Save(Manager manager)
        {
            var repo = new ManagerRepository();
            repo.Add(manager);

            return Ok();
        }
    }
}