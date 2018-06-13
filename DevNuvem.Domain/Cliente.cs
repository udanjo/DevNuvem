
namespace DevNuvem.Domain
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public int idade { get; set; }

        public override string ToString()
        {
            return this.nome;
        }

    }
}
