using Academia.Application.AlunoModulo.Queries;
using FluentValidation;

namespace Academia.Application.ProfessorModulo.Queries
{
    public class GetProfessorByIdQueryValidator : AbstractValidator<GetProfessorByIdQuery>
    {
        public GetProfessorByIdQueryValidator()
        {
            RuleFor(x => x.ProfessorId)
                .NotEmpty()
                .WithMessage("O Id do Professor é obrigatório")
                .NotNull();
        }
    }
}
