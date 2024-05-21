using System.Text.Json.Serialization;

namespace QuoteLevelling.Model
{
    public class Endereco
    {
        [JsonPropertyName("id_endereco")]
        public int IdEndereco { get; set; }

        [JsonPropertyName("rua_endereco")]
        public String RuaEndereco { get; set; }

        [JsonPropertyName("cidade_endereco")]
        public String CidadeEndereco { get; set; }

        [JsonPropertyName("uf_endereco")]
        public String UfEndereco { get; set; }

        [JsonPropertyName("cep_endereco")]
        public String CepEndereco { get; set; }

        [JsonPropertyName("numero_endereco")]
        public String NumeroEndereco { get; set; }

    }
}
