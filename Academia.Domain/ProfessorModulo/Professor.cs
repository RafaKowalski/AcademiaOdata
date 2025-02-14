using Academia.Domain.AlunoModulo;

namespace Academia.Domain.ProfessorModulo
{
    public class Professor
    {
        public Guid ProfessorId { get; set; }
        public required string Nome { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
