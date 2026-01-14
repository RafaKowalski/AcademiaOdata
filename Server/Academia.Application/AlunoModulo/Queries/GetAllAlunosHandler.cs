using Academia.Application.AlunoModulo.Services;
using Academia.Domain.AlunoModulo;
using MediatR;

namespace Academia.Application.AlunoModulo.Queries
{
    public class GetAllAlunosHandler : IRequestHandler<GetAllAlunosQuery, IEnumerable<Aluno>>
    {
        private readonly IAlunoServices _alunoService;

        public GetAllAlunosHandler(IAlunoServices alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task<IEnumerable<Aluno>> Handle(GetAllAlunosQuery request, CancellationToken cancellationToken)
        {
            return await _alunoService.GetAllAlunos();
        }
    }
}
