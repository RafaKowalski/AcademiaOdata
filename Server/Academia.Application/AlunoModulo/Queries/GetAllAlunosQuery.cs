using Academia.Application.AlunoModulo.Services;
using Academia.Domain.AlunoModulo;
using MediatR;

namespace Academia.Application.AlunoModulo.Queries
{
    public class GetAllAlunosQuery : IRequest<IEnumerable<Aluno>>
    {
        public IEnumerable<Aluno> Alunos { get; set; }
    }
}
