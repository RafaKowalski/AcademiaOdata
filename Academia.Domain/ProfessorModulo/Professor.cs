using Academia.Domain.AlunoModulo;
using System.Text.Json.Serialization;

namespace Academia.Domain.ProfessorModulo
{
    public class Professor
    {
        public Guid ProfessorId { get; set; }
        public required string Nome { get; set; }
        [JsonIgnore]
        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
