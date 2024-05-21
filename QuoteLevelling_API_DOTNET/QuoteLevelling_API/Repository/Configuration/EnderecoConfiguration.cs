using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuoteLevelling.Model;

namespace QuoteLevellingAPI.Repository.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
           builder.ToTable("TB_ENDERECO");
            builder.HasKey(endereco => endereco.IdEndereco);
            builder.Property(endereco => endereco.RuaEndereco).HasColumnType("varchar(40)").HasColumnName("rua_endereco");
            builder.Property(endereco => endereco.CidadeEndereco).HasColumnType("varchar(40)").HasColumnName("cidade_endereco");
            builder.Property(endereco => endereco.UfEndereco).HasColumnType("varchar(3)").HasColumnName("uf_endereco");
            builder.Property(endereco => endereco.CepEndereco).HasColumnType("varchar(9)").HasColumnName("cep_endereco");
            builder.Property(endereco => endereco.NumeroEndereco).HasColumnType("varchar(40)").HasColumnName("numero_endereco");
        }
    }
}
