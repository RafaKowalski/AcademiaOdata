using Academia.Application.AlunoModulo.Queries;
using Academia.Application.ProfessorModulo.Services;
using Academia.Domain.AlunoModulo;
using Academia.Domain.ProfessorModulo;
using MediatR;

namespace Academia.Application.ProfessorModulo.Queries
{
    public class GetProfessorByIdHandler : IRequestHandler<GetProfessorByIdQuery, Professor>
    {
        private readonly IProfessorService _professorService;

        public GetProfessorByIdHandler(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        public async Task<Professor> Handle(GetProfessorByIdQuery request, CancellationToken cancellationToken)
        {
            return await _professorService.GetProfessorById(request.ProfessorId, cancellationToken);
        }
    }
}
