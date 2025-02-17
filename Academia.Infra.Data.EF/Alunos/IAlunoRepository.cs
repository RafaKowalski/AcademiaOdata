using Academia.Domain.AlunoModulo;

namespace Academia.Infra.Data.EF.Alunos
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> GetAllAlunos();
        Task<Aluno> GetAlunoById(Guid id);
        Task<Aluno> AddAluno(Aluno aluno);
    }
}
