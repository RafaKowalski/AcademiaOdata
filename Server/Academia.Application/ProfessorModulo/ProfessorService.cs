using Academia.Domain.ProfessorModulo;
using Academia.Infra.Data.EF.Professores;
using Microsoft.Extensions.Logging;

namespace Academia.Application.ProfessorModulo
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        private readonly ILogger<IProfessorService> _logger;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public async Task<IEnumerable<Professor>> GetAllProfessores()
        {
            var todosProfessores = await _professorRepository.GetAllProfessores();

            if (todosProfessores == null)
                _logger.LogInformation("Não existe nenhum aluno");

            return todosProfessores;
        }

        public async Task<Professor> GetProfessorById(Guid id)
        {
            var professorPorId = await _professorRepository.GetProfessorById(id);

            if (professorPorId == null)
            {
                var errorMessage = $"Não existe o ID: {id}";
                _logger.LogError(errorMessage);
                throw new KeyNotFoundException(errorMessage);
            }

            return professorPorId;
        }

        public async Task<Professor> AddProfessor(Professor professor)
        {
            var addAluno = await _professorRepository.AddProfessor(professor);

            return addAluno;
        }
    }
}
