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

        public async Task<Aluno> UpdateAluno(Aluno aluno)
        {
            var alunoExistente = await _context.Alunos.FindAsync(aluno.AlunoId);
            if (alunoExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }
            alunoExistente.Nome = aluno.Nome;
            alunoExistente.Altura = aluno.Altura;
            alunoExistente.Peso = aluno.Peso;
            alunoExistente.Email = aluno.Email;
            alunoExistente.Telefone = aluno.Telefone;
            alunoExistente.ProfessorResponsavelId = aluno.ProfessorResponsavelId;
            await _context.SaveChangesAsync();
            return alunoExistente;
        }

        public async Task DeleteAluno(Guid id)
        {
            var alunoExistente = await _context.Alunos.FindAsync(id);
            if (alunoExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }
            _context.Alunos.Remove(alunoExistente);
            await _context.SaveChangesAsync();
        }
    }
}
