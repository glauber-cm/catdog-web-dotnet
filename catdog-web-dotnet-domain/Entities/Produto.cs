namespace CatdogWeb.Domain
{
    public class Produto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdTipoProduto { get; set; }

        public TipoProduto TipoProduto { get; set; }
    }
}
