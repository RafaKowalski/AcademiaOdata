using Academia.Domain.ProfessorModulo;

namespace Academia.Domain.AlunoModulo
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }
        public string Nome { get; set; }
        public Professor? ProfessorResponsavel { get; set; }
    }
}
