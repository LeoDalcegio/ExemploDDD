using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.IApplication;
using ExemploDDD.Domain.IRepository;
using ExemploDDD.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExemploDDD.Application
{
    public class ProdutoApplication : IProdutoApplication
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoMapper _produtoMapper;

        // Rever para melhor injeção de dependencia, passar como parametro
        public ProdutoApplication(IProdutoRepository produtoRepository, IProdutoMapper produtoMapper)
        {
            _produtoRepository = produtoRepository;
            _produtoMapper = produtoMapper;
        }

        public async Task<ProdutoDTO> Adicionar(ProdutoDTO produto)
        {
            var objProduto = _produtoMapper.MapperToEntity(produto);

            var categoriaNova = await _produtoRepository.AdicionarProduto(objProduto);

            return _produtoMapper.MapperToDTO(categoriaNova);
        }

        public async Task<ProdutoDTO> BuscarPorId(int idProduto)
        {
            var objProduto = await _produtoRepository.BuscarProdutoPorId(idProduto);

            return _produtoMapper.MapperToDTO(objProduto);
        }

        public async Task<IEnumerable<ProdutoDTO>> ListarTodos()
        {
            var objProduto = await _produtoRepository.ListarTodosOsProdutos();

            return _produtoMapper.MapperListProdutos(objProduto);
        }

        public async Task Remover(int idProduto)
        {
            await _produtoRepository.RemoverProdutoPeloId(idProduto);
        }
    }
}