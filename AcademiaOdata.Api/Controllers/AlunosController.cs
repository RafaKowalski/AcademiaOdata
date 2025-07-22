using Academia.Application.AlunoModulo.Commands;
using Academia.Application.AlunoModulo.Services;
using Academia.Domain.AlunoModulo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace AcademiaOdata.Api.Controllers
{
    [EnableQuery]
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoServices _alunoService;
        private readonly IMediator _mediator;

        public AlunosController(IAlunoServices alunoService, IMediator mediator)
        {
            _alunoService = alunoService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAllAlunos()
        {
            return Ok(await _alunoService.GetAllAlunos());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAlunosById(Guid id)
        {
            return Ok(await _alunoService.GetAlunoById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> AddAluno(AddAlunoCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
