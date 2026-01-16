using Academia.Domain.ProfessorModulo;
using MediatR;

namespace Academia.Application.ProfessorModulo.Queries
{
    public class GetProfessorByIdQuery : IRequest<Professor>
    {
        public Guid ProfessorId { get; set; }
    }
}
