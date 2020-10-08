using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.Entidades;
using ExemploDDD.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace ExemploDDD.Infra.CrossCutting.Adapter.Map
{
    public class ProdutoMapper : IProdutoMapper
    {
        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto
            {
                Id = (int)produtoDTO.Id,
                CategoriaId = produtoDTO.CategoriaId,
                Descricao = produtoDTO.Descricao,
                Preco = produtoDTO.Preco,
                QuantidadeEmEstoque = produtoDTO.QuantidadeEmEstoque
            };

            return produto;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id,
                    CategoriaId = item.CategoriaId,
                    Descricao = item.Descricao,
                    Preco = item.Preco,
                    QuantidadeEmEstoque = item.QuantidadeEmEstoque
                };
          
                produtoDTOs.Add(produtoDTO);

            }

            return produtoDTOs;
        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {

            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = produto.Id,
                CategoriaId = produto.CategoriaId,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                QuantidadeEmEstoque = produto.QuantidadeEmEstoque
            };

            return produtoDTO;

        }
    }
}