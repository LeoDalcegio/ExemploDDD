using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.IRepository;
using ExemploDDD.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExemploDDD.Domain.IApplication;

namespace ExemploDDD.Application
{
    public class CategoriaApplication : ICategoriaApplication
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ICategoriaMapper _categoriaMapper;

        public CategoriaApplication(ICategoriaRepository categoriaRepository, ICategoriaMapper categoriaMapper)
        {
            _categoriaRepository = categoriaRepository;
            _categoriaMapper = categoriaMapper;
        }

        public async Task<CategoriaDTO> Adicionar(CategoriaDTO categoria)
        {
            var objCategoria = _categoriaMapper.MapperToEntity(categoria);
            
            var categoriaNova = await _categoriaRepository.AdicionarCategoria(objCategoria);

            return _categoriaMapper.MapperToDTO(categoriaNova);
        }

        public async Task<CategoriaDTO> BuscarPorId(int idCategoria)
        {
            var objCategoria = await _categoriaRepository.BuscarCategoriaPorId(idCategoria);

            return _categoriaMapper.MapperToDTO(objCategoria);
        }
       

        public async Task<IEnumerable<CategoriaDTO>> ListarTodas()
        {
            var objCategoria = await _categoriaRepository.ListarTodasAsCategorias();

            return _categoriaMapper.MapperListCategorias(objCategoria);
        }

        public async Task Remover(int idCategoria)
        {
            await _categoriaRepository.RemoverCategoriaPeloId(idCategoria);
        }
    }
}