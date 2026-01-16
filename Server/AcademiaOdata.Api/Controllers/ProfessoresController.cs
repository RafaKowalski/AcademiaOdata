using Academia.Application.ProfessorModulo.Queries;
using Academia.Application.ProfessorModulo.Services;
using Academia.Domain.ProfessorModulo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Threading;

namespace AcademiaOdata.Api.Controllers
{
    [EnableQuery]
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessorService _professorService;
        private readonly IMediator _mediator;

        public ProfessoresController(IProfessorService professorService, IMediator mediator)
        {
            _professorService = professorService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> GetAllProfessores()
        {
            var response = await _mediator.Send(new GetAllProfessoresQuery());

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<Professor>>> GetProfessorById(Guid id)
        {
            var response = await _mediator.Send(new GetProfessorByIdQuery { ProfessorId = id});

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Professor>> AddProfessor(Professor professor)
        {
            await _professorService.AddProfessor(professor);

            return Created($"/api/alunos/{professor.ProfessorId}", professor);
        }
    }
}
