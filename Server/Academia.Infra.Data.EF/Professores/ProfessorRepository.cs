using Academia.Domain.ProfessorModulo;
using Microsoft.EntityFrameworkCore;

namespace Academia.Infra.Data.EF.Professores
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly AcademiaDbContext _context;

        public ProfessorRepository(AcademiaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Professor>> GetAllProfessores()
        {
            return await _context.Professores.ToListAsync();
        }

        public async Task<Professor> GetProfessorById(Guid id)
        {
            return await _context.Professores.FindAsync(id);
        }

        public async Task<Professor> AddProfessor(Professor professor)
        {
            var novoProfessor = _context.Professores.Add(professor).Entity;
            await _context.SaveChangesAsync();

            return novoProfessor;

        }
    }
}
