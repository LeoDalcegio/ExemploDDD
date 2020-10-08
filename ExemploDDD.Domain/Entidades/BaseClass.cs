using System;

namespace ExemploDDD.Domain.Entidades
{
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataModificacao { get; set; }
        
    }
}