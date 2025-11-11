using FluentValidation;

namespace Academia.Application.AlunoModulo.Commands
{
    public sealed class AddAlunoCommandValidator : AbstractValidator<AddAlunoCommand>
    {
        public AddAlunoCommandValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Altura).NotEmpty();
            RuleFor(x => x.Peso).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Telefone).NotEmpty();
        }
    }
}
