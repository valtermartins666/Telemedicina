using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Person;

namespace VMS.Desafio.Telemedicina.Controllers
{
    
    [Route("api/v1/appointment")]
    public class AppointmentController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;

        public AppointmentController(ILogger<RegistrationController> logger)
        {
                _logger= logger;
        }
        ///<summary>
        /// Busca todas as consultas geradas no sistema
        /// </summary>        
        /// <returns>Dados de todos os pacientes</returns>
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
        ///<summary>
        /// Busca consultas geradas no sistema baseado num paciente específico
        /// </summary>    
        /// <param name="id">Codigo interno do paciente</param>
        /// <returns>Dados do paciente</returns>
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
        ///<summary>
        /// Inclui novas consultas 
        /// </summary>    
        /// <param name="registration">Dados do paciente </param>
        [HttpPost("add-appointment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostAppointmentAsync([FromBody] Person person, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[APPOINTMENT] - Add appointment data");

            return Ok();
        }

        ///<summary>
        /// Cancela uma consulta existente
        /// </summary> 
        [HttpPost("cancel-appointment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostCancelAppointmentAsync([FromBody] Person person, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[APPOINTMENT] - Canceling an appointment data");

            return Ok();
        }
    }
}
