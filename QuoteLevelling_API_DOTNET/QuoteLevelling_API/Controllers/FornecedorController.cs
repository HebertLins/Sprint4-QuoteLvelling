using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("fornecedor")]
    public class FornecedorController : Controller
    {
        private static List<Fornecedor> _fornecedores = new List<Fornecedor>
    {
        new Fornecedor
        {
            id_fornecedor = 1,
            nome_fornecedor = "Fornecedor A",
            descricao_fornecedor = "Descrição do Fornecedor A",
            tipo_fornecedor = "Tipo A",
            cnpj_fornecedor = "12345678901234",
            avaliacao_fornecedor = 4.5,
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
            return Ok(_fornecedores);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var fornecedor = _fornecedores.Find(f => f.id_fornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }
    }

}
