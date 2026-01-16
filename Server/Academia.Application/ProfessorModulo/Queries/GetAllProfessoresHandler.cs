using Academia.Application.ProfessorModulo.Services;
using Academia.Domain.ProfessorModulo;
using MediatR;

namespace Academia.Application.ProfessorModulo.Queries
{
    public class GetAllProfessoresHandler : IRequestHandler<GetAllProfessoresQuery, IEnumerable<Professor>>
    {
        private readonly IProfessorService _professorService;

        public GetAllProfessoresHandler(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        public async Task<IEnumerable<Professor>> Handle(GetAllProfessoresQuery request, CancellationToken cancellationToken)
        {
            return await _professorService.GetAllProfessores(cancellationToken);
        }
    }
}
