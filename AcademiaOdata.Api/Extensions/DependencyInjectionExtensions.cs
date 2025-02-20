using Academia.Application.AlunoModulo;
using Academia.Infra.Data.EF.Alunos;

namespace AcademiaOdata.Api.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            // Registra injeções de dependencias da camada de Services
            services.AddTransient<IAlunoServices, AlunoService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // Registra injeções de dependencias da camada de Infrastructure
            services.AddTransient<IAlunoRepository, AlunoRepository>();

            return services;
        }
    }
}
