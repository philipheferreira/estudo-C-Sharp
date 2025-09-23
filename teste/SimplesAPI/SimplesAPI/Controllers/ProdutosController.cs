using Microsoft.AspNetCore.Mvc;
using SimplesAPI.Models;
using SimplesAPI.Repositories;

namespace SimplesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private readonly ProdutoRepository _repository;

        public ProdutosController()
        {
            _repository = new ProdutoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _repository.GetAll();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _repository.GetById(id);
            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            _repository.Add(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id)
                return BadRequest();

            _repository.Update(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }

    }
}
