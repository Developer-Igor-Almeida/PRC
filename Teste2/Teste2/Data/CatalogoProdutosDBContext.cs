using Microsoft.EntityFrameworkCore;
using Teste2.Models;

namespace Teste2.Data

{
    public class CatalogoProdutosDBContext : DbContext
    {
        public CatalogoProdutosDBContext(DbContextOptions<CatalogoProdutosDBContext> options) : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }
    }
}
