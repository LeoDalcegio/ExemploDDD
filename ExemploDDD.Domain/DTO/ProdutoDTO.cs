namespace ExemploDDD.Domain.DTO
{
    public class ProdutoDTO
    {
        public int? Id { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int QuantidadeEmEstoque { get; set; }

        public int CategoriaId { get; set; }

    }
}