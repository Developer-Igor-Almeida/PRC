using Microsoft.EntityFrameworkCore;
using Teste2.Data;

namespace Teste2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adiciona o serviço de banco de dados em memória
            builder.Services.AddDbContext<CatalogoProdutosDBContext>(options =>options.UseInMemoryDatabase(databaseName: "ProdutosDB"));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
