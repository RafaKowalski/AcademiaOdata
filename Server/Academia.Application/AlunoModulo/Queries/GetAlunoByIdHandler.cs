using Academia.Application.AlunoModulo.Services;
using Academia.Domain.AlunoModulo;
using MediatR;

namespace Academia.Application.AlunoModulo.Queries
{
    public class GetAlunoByIdHandler : IRequestHandler<GetAlunoByIdQuery, Aluno>
    {
        private readonly IAlunoServices _alunoService;

        public GetAlunoByIdHandler(IAlunoServices alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task<Aluno> Handle(GetAlunoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _alunoService.GetAlunoById(request.AlunoId);
        }
    }
}
