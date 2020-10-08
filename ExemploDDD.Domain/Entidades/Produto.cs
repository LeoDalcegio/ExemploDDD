using System.ComponentModel.DataAnnotations;

namespace ExemploDDD.Domain.Entidades
{
    public class Produto : BaseClass
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Descrição inválido!")]
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int QuantidadeEmEstoque { get; set; }

        public int CategoriaId { get; set; }
        
        public Categoria Categoria { get; set; }

        public bool PodeVender()
        {
            return QuantidadeEmEstoque > 0;
        }

        public void Vendeu()
        {
            if (PodeVender())
                QuantidadeEmEstoque--;
        }

        public void Comprou(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }
    }
}