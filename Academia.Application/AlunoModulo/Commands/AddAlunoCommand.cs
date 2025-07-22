using Academia.Domain.AlunoModulo;
using Academia.Domain.ProfessorModulo;
using MediatR;

namespace Academia.Application.AlunoModulo.Commands
{
    public class AddAlunoCommand : IRequest<Aluno>
    {
        public Guid AlunoId { get; set; }
        public string? Nome { get; set; }
        public string? Altura { get; set; }
        public string? Peso { get; set; }

        public string? Email { get; set; }

        public string? Telefone { get; set; }
        public Guid ProfessorResponsavelId { get; set; }
    }
}
