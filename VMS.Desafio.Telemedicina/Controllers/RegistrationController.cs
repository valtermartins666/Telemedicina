using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Person;

namespace VMS.Desafio.Telemedicina.Controllers
{
    //[ApiVersion("1")]
    [Route("api/v{version:apiversion}/person-data")]
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;       

        public RegistrationController(ILogger<RegistrationController> logger)
        {
            _logger = logger; 
        }

        [HttpGet("person")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll_PersonAsync([FromServices] IDoctorRepository doctorRepository)
        {
            _logger.LogDebug("[PERSON] - Starting getting person data");

            var result = await doctorRepository.GetAllAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("person/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPersonByIdAsync([FromRoute][Required] Guid id, [FromServices] IDoctorRepository repository, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[PERSON] - Starting getting person data by Id");
            
            var result = await repository.GetByIdAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("add-person")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostPersonAsync([FromBody] Person person, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[PERSON] - Add person data");
            
            return Ok();
        }
    }
}
