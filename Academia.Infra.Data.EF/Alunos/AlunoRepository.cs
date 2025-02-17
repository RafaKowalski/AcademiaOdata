using Academia.Domain.AlunoModulo;
using Microsoft.EntityFrameworkCore;

namespace Academia.Infra.Data.EF.Alunos
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AcademiaDbContext _context;

        public AlunoRepository(AcademiaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task<Aluno> GetAlunoById(Guid id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task<Aluno> AddAluno(Aluno aluno)
        {
            var novoAluno = _context.Alunos.Add(aluno).Entity;
            await _context.SaveChangesAsync();

            return novoAluno;

        }
    }
}
