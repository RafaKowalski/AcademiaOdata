using Academia.Domain.AlunoModulo;
using Academia.Domain.ProfessorModulo;
using MediatR;

namespace Academia.Application.ProfessorModulo.Queries
{
    public class GetAllProfessoresQuery : IRequest<IEnumerable<Professor>>
    {
        public IEnumerable<Professor> Professores { get; set; }
    }
}
