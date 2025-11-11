using Academia.Domain.ProfessorModulo;

namespace Academia.Infra.Data.EF.Professores
{
    public interface IProfessorRepository
    {
        Task<IEnumerable<Professor>> GetAllProfessores();
        Task<Professor> GetProfessorById(Guid id);
        Task<Professor> AddProfessor(Professor professor);
    }
}
