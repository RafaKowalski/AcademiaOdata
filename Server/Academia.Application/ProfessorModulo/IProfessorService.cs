using Academia.Domain.ProfessorModulo;

namespace Academia.Application.ProfessorModulo
{
    public interface IProfessorService
    {
        Task<IEnumerable<Professor>> GetAllProfessores();
        Task<Professor> GetProfessorById(Guid id);
        Task<Professor> AddProfessor(Professor professor);
    }
}
