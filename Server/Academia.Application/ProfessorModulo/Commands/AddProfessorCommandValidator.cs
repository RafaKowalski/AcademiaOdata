using Academia.Application.AlunoModulo.Commands;
using FluentValidation;

namespace Academia.Application.ProfessorModulo.Commands
{
    public class AddProfessorCommandValidator : AbstractValidator<AddProfessorCommand>
    {
        public AddProfessorCommandValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
        }
    }
}
