using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.Entidades;
using System.Collections.Generic;

namespace ExemploDDD.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IProdutoMapper
    {
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos);

        ProdutoDTO MapperToDTO(Produto produto);
    }
}