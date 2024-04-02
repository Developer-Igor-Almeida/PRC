using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teste2.Data;
using Teste2.Models;

namespace Teste2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly CatalogoProdutosDBContext _context;

        public ProdutosController(CatalogoProdutosDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Produtos>> PostProduct(Produtos produtos)
        {
            _context.Produtos.Add(produtos);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = produtos.ID }, produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produtos>> GetProduct(int id)
        {
            var produtos = await _context.Produtos.FindAsync(id);

            if (produtos == null)
            {
                return NotFound();
            }

            return produtos;
        }
    }
}
