using Academia.Application.AlunoModulo;
using Academia.Application.AlunoModulo.Commands;
using Academia.Application.AlunoModulo.Mappers;
using Academia.Application.AlunoModulo.Queries;
using Academia.Application.AlunoModulo.Services;
using Academia.Application.ProfessorModulo;
using Academia.Infra.Data.EF.Alunos;
using Academia.Infra.Data.EF.Professores;
using FluentValidation;

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

        public static IServiceCollection AddMediatorConfig(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(AddAlunoCommand).Assembly);
                cfg.RegisterServicesFromAssembly(typeof(GetAlunoByIdQuery).Assembly);
            });

            services.AddValidatorsFromAssembly(typeof(AddAlunoCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(GetAlunoByIdQueryValidator).Assembly);

            return services;
        }

        public static IServiceCollection AddMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AddAlunoCommandHandler).Assembly);

            services.AddAutoMapper(typeof(AddAlunoMapper).Assembly);

            services.AddAutoMapper(typeof(GetAlunoByIdHandler).Assembly);

            services.AddAutoMapper(typeof(GetAlunoByIdMapper).Assembly);

            return services;
        }
    }
}
