using DevNuvem.Domain;
using DevNuvem.Infra.Mapping;
using System.Data.Entity;

namespace DevNuvem.Infra.DataContexts
{
    public class DevNuvemDataContext : DbContext
    {

        public DevNuvemDataContext() 
            : base("DevNuvemConnectionString")
        {
            Database.SetInitializer<DevNuvemDataContext>(new DevNuvemDataContextInitializer());
        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMaps());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DevNuvemDataContextInitializer : DropCreateDatabaseIfModelChanges<DevNuvemDataContext>
    {
        protected override void Seed(DevNuvemDataContext context)
        {

            context.Cliente.Add(new Cliente { idCliente = 1, nome = "Ueverson", cidade = "Fernandopolis", idade = 27 });
            context.Cliente.Add(new Cliente { idCliente = 2, nome = "Juliana", cidade = "Ribeirão Preto", idade = 35 });
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}
