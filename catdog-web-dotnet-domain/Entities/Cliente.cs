namespace CatdogWeb.Domain
{
    public class Cliente
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public int? IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
        public int IdAnimal { get; set; }
        public Animal Animal { get; set; }

    }
}
