using catdog_web_dotnet_domain.Entities;

namespace CatdogWeb.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public int Senha { get; set; }
        public decimal Salario { get; set; }
        public string IdCargo { get; set; }
        public TipoCargo TipoCargo { get; set; }

    }
}
