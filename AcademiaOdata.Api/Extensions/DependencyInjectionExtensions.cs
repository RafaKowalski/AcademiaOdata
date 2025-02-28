using Academia.Application.AlunoModulo;
using Academia.Application.ProfessorModulo;
using Academia.Infra.Data.EF.Alunos;
using Academia.Infra.Data.EF.Professores;

namespace AcademiaOdata.Api.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            // Registra injeções de dependencias da camada de Services
            services.AddTransient<IAlunoServices, AlunoService>();
            services.AddTransient<IProfessorService, ProfessorService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // Registra injeções de dependencias da camada de Infrastructure
            services.AddTransient<IAlunoRepository, AlunoRepository>();
            services.AddTransient<IProfessorRepository, ProfessorRepository>();

            return services;
        }
    }
}
