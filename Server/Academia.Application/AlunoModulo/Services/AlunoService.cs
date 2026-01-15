using Academia.Application.AlunoModulo.Services;
using Academia.Domain.AlunoModulo;
using Academia.Infra.Data.EF.Alunos;
using Microsoft.Extensions.Logging;

namespace Academia.Application.AlunoModulo
{
    public class AlunoService : IAlunoServices
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ILogger<IAlunoServices> _logger;

        public AlunoService(IAlunoRepository alunoRepository, ILogger<IAlunoServices> logger)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<IEnumerable<Aluno>> GetAllAlunos(CancellationToken cancellationToken)
        {
            var todosAlunos = await _alunoRepository.GetAllAlunos();

            if (todosAlunos == null)
                _logger.LogInformation("Não existe nenhum aluno");

            return todosAlunos;
        }

        public async Task<Aluno> GetAlunoById(Guid id, CancellationToken cancellationToken)
        {
            var alunoPorId = await _alunoRepository.GetAlunoById(id);

            if (alunoPorId == null)
            {
                var errorMessage = $"Não existe o ID: {id}";
                _logger.LogError(errorMessage);
                throw new KeyNotFoundException(errorMessage);
            }

            return alunoPorId;
        }

        public async Task<Aluno> AddAluno(Aluno aluno)
        {
            var addAluno = await _alunoRepository.AddAluno(aluno);

            return addAluno;
        }
    }
}
