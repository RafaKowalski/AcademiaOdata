using Academia.Domain.AlunoModulo;

namespace Academia.Application.AlunoModulo.Services
{
    public interface IAlunoServices
    {
        Task<IEnumerable<Aluno>> GetAllAlunos(CancellationToken cancellationToken);
        Task<Aluno> GetAlunoById(Guid id, CancellationToken cancellationToken);
        Task<Aluno> AddAluno(Aluno aluno);
    }
}
