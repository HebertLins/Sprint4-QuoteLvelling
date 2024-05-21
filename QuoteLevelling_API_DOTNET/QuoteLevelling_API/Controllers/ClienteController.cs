using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : Controller
    {
        private static List<Cliente> _clientes = new List<Cliente>{
            new Cliente
            {
                id_cliente = 1,
                nome_cliente = "Cliente A",
                descricao_cliente = "Descrição do Cliente A",
                tipo_cliente = "Tipo A",
                cnpj_cliente = "12345678901234",
                enderecos = new List<Endereco>
                {
                    new Endereco { IdEndereco = 1, RuaEndereco = "Rua A", CidadeEndereco = "Cidade A", UfEndereco = "Estado A", CepEndereco = "00000-000", NumeroEndereco = "123" },
                    new Endereco { IdEndereco = 2, RuaEndereco = "Rua B", CidadeEndereco = "Cidade B", UfEndereco = "Estado B", CepEndereco = "11111-111", NumeroEndereco = "456" }
                }
            }
           };


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = _clientes.Find(c => c.id_cliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
    }
}
    

