using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.Entidades;
using ExemploDDD.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace ExemploDDD.Infra.CrossCutting.Adapter.Map
{
    public class CategoriaMapper : ICategoriaMapper
    {
        List<CategoriaDTO> categoriaDTOs = new List<CategoriaDTO>();

        public Categoria MapperToEntity(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = new Categoria
            {
                Id = (int)categoriaDTO.Id,
                Nome = categoriaDTO.Nome,
                Descricao = categoriaDTO.Descricao
            };

            return categoria;
        }

        public IEnumerable<CategoriaDTO> MapperListCategorias(IEnumerable<Categoria> categorias)
        {
            foreach (var item in categorias)
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Descricao = item.Descricao
                };

                categoriaDTOs.Add(categoriaDTO);

            }

            return categoriaDTOs;
        }

        public CategoriaDTO MapperToDTO(Categoria categoria)
        {

            CategoriaDTO categoriaDTO = new CategoriaDTO
            {
                Id = categoria.Id,
                Nome = categoria.Nome,
                Descricao = categoria.Descricao
            };

            return categoriaDTO;

        }
    }
}