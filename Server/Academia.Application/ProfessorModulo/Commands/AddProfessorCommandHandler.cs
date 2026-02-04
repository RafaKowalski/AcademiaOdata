using Academia.Application.ProfessorModulo.Services;
using Academia.Domain.ProfessorModulo;
using AutoMapper;
using MediatR;

namespace Academia.Application.ProfessorModulo.Commands
{
    public class AddProfessorCommandHandler : IRequestHandler<AddProfessorCommand, Professor>
    {
        private readonly IProfessorService _professorService;
        private readonly IMapper _mapper;

        public AddProfessorCommandHandler(IProfessorService professorService, IMapper mapper)
        {
            _professorService = professorService;
            _mapper = mapper;
        }

        public async Task<Professor> Handle(AddProfessorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newProfessor = _mapper.Map<Professor>(request);

                return await _professorService.AddProfessor(newProfessor);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao adicionar novo professor: ", ex);
            }
        }
    }
}
