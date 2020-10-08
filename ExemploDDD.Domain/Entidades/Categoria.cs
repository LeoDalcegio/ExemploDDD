using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExemploDDD.Domain.Entidades
{
    public class Categoria : BaseClass
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome inválido!")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Descrição inválida!")]
        public string Descricao { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}