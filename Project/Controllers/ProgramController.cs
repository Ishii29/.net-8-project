using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Core;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IProgrmRepository _progrmRepository;
        public ProgramController(IProgrmRepository progrmRepository)
        {
            this._progrmRepository = progrmRepository;
        }

        public async Task<ActionResult<IEnumerable<Programs>>> GetAllProgram(string employerID)
        {
            var programs = await _progrmRepository.GetProgramsAsync(employerID);
            return Ok(programs);
        }
    }
}
