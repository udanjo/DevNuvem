using DevNuvem.Domain;
using System.Data.Entity.ModelConfiguration;

namespace DevNuvem.Infra.Mapping
{
    public class ClienteMaps : EntityTypeConfiguration<Cliente>
    {
        public ClienteMaps()
        {
            ToTable("Cliente");

            HasKey(X => X.idCliente);
            Property(X => X.nome).HasMaxLength(50).IsRequired();
            Property(x => x.cidade).HasMaxLength(100);
            

    }
    }
}
