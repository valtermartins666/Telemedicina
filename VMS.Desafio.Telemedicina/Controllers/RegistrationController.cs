using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Person;

namespace VMS.Desafio.Telemedicina.Controllers
{
    //[ApiVersion("1")]
    [Route("api/v{version:apiversion}/registration")]
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;       

        public RegistrationController(ILogger<RegistrationController> logger)
        {
            _logger = logger; 
        }

        [HttpGet("registrations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll_RegistrationAsync([FromServices] IDoctorRepository doctorRepository)
        {
            _logger.LogDebug("[REGISTRATION] - Starting getting person data");

            var result = await doctorRepository.GetAllAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("registration/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRegistrationByIdAsync([FromRoute][Required] Guid id, [FromServices] IDoctorRepository repository, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[REGISTRATION] - Starting getting registration data by Id");
            
            var result = await repository.GetByIdAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("add-registration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostRegistrationAsync([FromBody] Person person, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[REGISTRATION] - Add registration data");             
            
            return Ok();
        }

        [HttpDelete("delete-registration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteRegistration([FromRoute][Required] Guid id, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[REGISTRATION] - Deleting registration data");

            return Ok();
        }
    }
}
