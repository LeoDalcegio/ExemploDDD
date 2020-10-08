using System;
using System.Collections.Generic;
using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.IApplication;
using Microsoft.AspNetCore.Mvc;

namespace ExemploDDD.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoApplication _produtoApplication;

        public ProdutosController(IProdutoApplication produtoApplication)
        {
            _produtoApplication = produtoApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_produtoApplication.ListarTodos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_produtoApplication.BuscarPorId(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _produtoApplication.Adicionar(produtoDTO);

                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete(int id)
        {
            try
            {
                _produtoApplication.Remover(id);

                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}