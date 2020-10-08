using ExemploDDD.Domain.Entidades;
using ExemploDDD.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using ExemploDDD.Infra.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExemploDDD.Infra.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlContext _context;

        public ProdutoRepository(SqlContext Context)
        {
            _context = Context;
        }

        public async Task<Produto> AdicionarProduto(Produto produto)
        {
            try
            {
                _context.Produtos.Add(produto);
                
                await _context.SaveChangesAsync();

                return produto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task RemoverProdutoPeloId(int idProduto)
        {
            try
            {
                Produto produto = await BuscarProdutoPorId(idProduto);

                _context.Produtos.Remove(produto);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Produto>> ListarTodosOsProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> BuscarProdutoPorId(int idProduto)
        {
            return await _context.Produtos.FindAsync(idProduto);
        }
    }
}