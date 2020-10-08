using System.Collections.Generic;
using System.Threading.Tasks;
using ExemploDDD.Domain.DTO;

namespace ExemploDDD.Domain.IApplication
{
    public interface IProdutoApplication
    {
        Task<ProdutoDTO> Adicionar(ProdutoDTO produto);
        Task Remover(int idProduto);
        Task<IEnumerable<ProdutoDTO>> ListarTodos();
        Task<ProdutoDTO> BuscarPorId(int idProduto);
    }
}