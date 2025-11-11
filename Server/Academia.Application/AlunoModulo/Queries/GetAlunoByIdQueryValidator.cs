using Academia.Application.AlunoModulo.Commands;
using FluentValidation;

namespace Academia.Application.AlunoModulo.Queries
{
    public class GetAlunoByIdQueryValidator : AbstractValidator<GetAlunoByIdQuery>
    {
        public GetAlunoByIdQueryValidator()
        {
            RuleFor(x => x.AlunoId)
                .NotEmpty()
                .WithMessage("O Id do aluno é obrigatório")
                .NotNull();
                
        }
    }
}
