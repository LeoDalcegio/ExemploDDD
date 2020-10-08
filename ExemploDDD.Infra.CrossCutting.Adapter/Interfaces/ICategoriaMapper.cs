using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.Entidades;
using System.Collections.Generic;

namespace ExemploDDD.Infra.CrossCutting.Adapter.Interfaces
{
    public interface ICategoriaMapper
    {
        Categoria MapperToEntity(CategoriaDTO categoriaDTO);

        IEnumerable<CategoriaDTO> MapperListCategorias(IEnumerable<Categoria> categorias);

        CategoriaDTO MapperToDTO(Categoria categoria);
    }
}