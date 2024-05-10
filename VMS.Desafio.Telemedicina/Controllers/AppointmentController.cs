using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Person;

namespace VMS.Desafio.Telemedicina.Controllers
{
    [Route("api/v{version:apiversion}/appointment")]
    public class AppointmentController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;

        public AppointmentController(ILogger<RegistrationController> logger)
        {
                _logger= logger;
        }

        [HttpGet("appointments")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll_AppointmentAsync([FromServices] IDoctorRepository doctorRepository)
        {
            _logger.LogDebug("[APPOINTMENT] - Starting getting all appointments data");

            var result = await doctorRepository.GetAllAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("appointment/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAppointmentByIdAsync([FromRoute][Required] Guid id, [FromServices] IDoctorRepository repository, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[APPOINTMENT] - Starting getting appointment data by Id");

            var result = await repository.GetByIdAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("add-appointment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostappointmentAsync([FromBody] Person person, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[APPOINTMENT] - Add appointment data");

            return Ok();
        }
        
    }
}
