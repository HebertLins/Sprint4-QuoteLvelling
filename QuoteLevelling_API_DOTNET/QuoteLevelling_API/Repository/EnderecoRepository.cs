using QuoteLevellingAPI.Repository.EntityRepository;

namespace QuoteLevellingAPI.Repository
{
    public class EnderecoRepository
    {
        private QuoteLevellingContext global;

        public EnderecoRepository(QuoteLevellingContext global)
        {
            this.global = global;
        }

        public List<EnderecoEntity> listAll() {   
            return global.Enderecos.ToList();
        }
    }
}
