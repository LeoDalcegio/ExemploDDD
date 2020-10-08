using System.Collections.Generic;
using System.Threading.Tasks;
using ExemploDDD.Domain.Entidades;

namespace ExemploDDD.Domain.IRepository
{
    public interface ICategoriaRepository
    {
        Task<Categoria> AdicionarCategoria(Categoria categoria);
        Task RemoverCategoriaPeloId(int idCategoria);
        Task<IEnumerable<Categoria>> ListarTodasAsCategorias();
        Task<Categoria> BuscarCategoriaPorId(int idCategoria);
    }
}