using System.Collections.Generic;
using System.Threading.Tasks;
using ExemploDDD.Domain.DTO;

namespace ExemploDDD.Domain.IApplication
{
    public interface ICategoriaApplication
    {
        Task<CategoriaDTO> Adicionar(CategoriaDTO categoria);
        Task Remover(int idCategoria);
        Task<IEnumerable<CategoriaDTO>> ListarTodas();
        Task<CategoriaDTO> BuscarPorId(int idCategoria);
    }
}