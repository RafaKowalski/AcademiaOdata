using Academia.Application.AlunoModulo.Services;
using Academia.Domain.AlunoModulo;
using AutoMapper;
using MediatR;

namespace Academia.Application.AlunoModulo.Commands
{
    public class AddAlunoCommandHandler : IRequestHandler<AddAlunoCommand, Aluno>
    {
        private readonly IAlunoServices _alunoService;
        private readonly IMapper _mapper;

        public AddAlunoCommandHandler(IAlunoServices alunoService, IMapper mapper)
        {
            _alunoService = alunoService;
            _mapper = mapper;
        }

        public async Task<Aluno> Handle(AddAlunoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.ProfessorResponsavelId == Guid.Empty)
                {
                    throw new Exception("O Id do Professor Responsável não pode ser vazio e deve ser passado um Id já cadastrado do banco");
                }

                var newAluno = _mapper.Map<Aluno>(request);

                return await _alunoService.AddAluno(newAluno);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar novo aluno", ex);
            }
        }
    }
}
