using Microsoft.EntityFrameworkCore;
using QuoteLevelling.Model;
using QuoteLevellingAPI.Repository.Configuration;
using QuoteLevellingAPI.Repository.EntityRepository;
using System.Diagnostics;

namespace QuoteLevellingAPI.Repository
{
    public class QuoteLevellingContext : DbContext
    {

        public DbSet <EnderecoEntity> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<EnderecoEntity>().HasNoKey();
            modelBuilder.Entity<EnderecoEntity>().ToTable("TB_ENDERECO");
            modelBuilder.Entity<EnderecoEntity>().Property(endereco => endereco.UfEndereco).HasColumnType("varchar(2)").HasColumnName("uf_endereco");
            modelBuilder.Entity<EnderecoEntity>().Property(endereco => endereco.RuaEndereco).HasColumnType("varchar(40)").HasColumnName("rua_endereco");
            modelBuilder.Entity<EnderecoEntity>().Property(endereco => endereco.CidadeEndereco).HasColumnType("varchar(40)").HasColumnName("cidade_endereco");
            modelBuilder.Entity<EnderecoEntity>().Property(endereco => endereco.UfEndereco).HasColumnType("varchar(3)").HasColumnName("uf_endereco");
            modelBuilder.Entity<EnderecoEntity>().Property(endereco => endereco.CepEndereco).HasColumnType("varchar(9)").HasColumnName("cep_endereco");
            modelBuilder.Entity<EnderecoEntity>().Property(endereco => endereco.NumeroEndereco).HasColumnType("varchar(40)").HasColumnName("numero_endereco");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=Rm97356;Password=fiap23;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)))");
        }

    }
}
