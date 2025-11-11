using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Academia.Infra.Data.EF
{
    public class AcademiaDbContextFactory : IDesignTimeDbContextFactory<AcademiaDbContext>
    {
        public AcademiaDbContext CreateDbContext(string[] args)
        {
            // Busca o appsettings.json no projeto da api
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "AcademiaOdata.Api");

            if (!Directory.Exists(basePath))
            {
                throw new Exception($"O diretório '{basePath}' não foi encontrado. Verifique o caminho.");
            }

            // Carrega as configurações do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AcademiaDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new AcademiaDbContext(optionsBuilder.Options);
        }
    }
}
