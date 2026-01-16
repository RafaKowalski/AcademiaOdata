using Academia.Domain.ProfessorModulo;

namespace Academia.Application.ProfessorModulo.Services
{
    public interface IProfessorService
    {
        Task<IEnumerable<Professor>> GetAllProfessores(CancellationToken cancellationToken);
        Task<Professor> GetProfessorById(Guid id, CancellationToken cancellationToken);
        Task<Professor> AddProfessor(Professor professor);
    }
}
