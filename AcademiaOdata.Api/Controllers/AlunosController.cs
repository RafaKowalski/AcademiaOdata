using Academia.Application.AlunoModulo;
using Academia.Domain.AlunoModulo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AcademiaOdata.Api.Controllers
{
    [EnableQuery]
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoServices _alunoService;

        public AlunosController(IAlunoServices alunoService)
        {
            _alunoService = alunoService;
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
        public async Task<ActionResult<Aluno>> AddAluno(Aluno aluno)
        {
            await _alunoService.AddAluno(aluno);

            return Created($"/api/alunos/{aluno.AlunoId}", aluno);
        }
    }
}
