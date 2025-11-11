using Academia.Application.ProfessorModulo;
using Academia.Domain.ProfessorModulo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace AcademiaOdata.Api.Controllers
{
    [EnableQuery]
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessoresController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> GetAllProfessores()
        {
            return Ok(await _professorService.GetAllProfessores());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<Professor>>> GetProfessorById(Guid id)
        {
            return Ok(await _professorService.GetProfessorById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Professor>> AddProfessor(Professor professor)
        {
            await _professorService.AddProfessor(professor);

            return Created($"/api/alunos/{professor.ProfessorId}", professor);
        }
    }
}
