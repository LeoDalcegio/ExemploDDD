using ExemploDDD.Domain.Entidades;
using ExemploDDD.Domain.IRepository;
using ExemploDDD.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExemploDDD.Infra.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly SqlContext _context;

        public CategoriaRepository(SqlContext Context)
        {
            _context = Context;
        }

        public async Task<Categoria> AdicionarCategoria(Categoria categoria)
        {
            try
            {
                _context.Categorias.Add(categoria);

                await _context.SaveChangesAsync();

                return categoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task RemoverCategoriaPeloId(int idCategoria)
        {
            try
            {
                Categoria categoria = await BuscarCategoriaPorId(idCategoria);

                _context.Categorias.Remove(categoria);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Categoria>> ListarTodasAsCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> BuscarCategoriaPorId(int idCategoria)
        {
            return await _context.Categorias.FindAsync(idCategoria);
        }
    }
}