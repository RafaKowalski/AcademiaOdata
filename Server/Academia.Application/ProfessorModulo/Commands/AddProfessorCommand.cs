using Academia.Domain.ProfessorModulo;
using MediatR;

namespace Academia.Application.ProfessorModulo.Commands
{
    public class AddProfessorCommand : IRequest<Professor>
    {
        public Guid ProfessorId { get; set; }
        public string Nome { get; set; }
    }
}
