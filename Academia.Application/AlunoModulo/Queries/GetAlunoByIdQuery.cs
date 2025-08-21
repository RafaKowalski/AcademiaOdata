using Academia.Domain.AlunoModulo;
using MediatR;

namespace Academia.Application.AlunoModulo.Queries
{
    public class GetAlunoByIdQuery : IRequest<Aluno>
    {
        public Guid AlunoId { get; set; }
    }
}
