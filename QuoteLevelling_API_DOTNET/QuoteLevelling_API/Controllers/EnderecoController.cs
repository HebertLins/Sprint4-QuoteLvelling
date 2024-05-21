using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;
using QuoteLevellingAPI.Repository;
using QuoteLevellingAPI.Repository.EntityRepository;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("endereco")]
    public class EnderecoController : Controller
    {
        EnderecoRepository enderecoRepository;
        public EnderecoController() {
            enderecoRepository = new EnderecoRepository(new QuoteLevellingContext());
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(enderecoRepository.listAll());
        }

    }
}
