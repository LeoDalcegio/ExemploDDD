using System.Collections.Generic;
using System.Threading.Tasks;
using ExemploDDD.Domain.Entidades;

namespace ExemploDDD.Domain.IRepository
{
    public interface IProdutoRepository
    {
        Task<Produto> AdicionarProduto(Produto produto);
        Task RemoverProdutoPeloId(int idProduto);
        Task<IEnumerable<Produto>> ListarTodosOsProdutos();
        Task<Produto> BuscarProdutoPorId(int idProduto);
    }
}