using System;
using System.Collections.Generic;
using ExemploDDD.Domain.DTO;
using ExemploDDD.Domain.IApplication;
using Microsoft.AspNetCore.Mvc;

namespace ExemploDDD.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaApplication _categoriaApplication;

        public CategoriasController(ICategoriaApplication categoriaApplication)
        {
            _categoriaApplication = categoriaApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_categoriaApplication.ListarTodas());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_categoriaApplication.BuscarPorId(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                _categoriaApplication.Adicionar(categoriaDTO);

                return Ok("Categoria Cadastrada com sucesso!");
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
                _categoriaApplication.Remover(id);

                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}