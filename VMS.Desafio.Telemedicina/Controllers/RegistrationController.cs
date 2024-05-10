using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VMS.Desafio.Telemedicina.Application.UseCases.Registration;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Person;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;

namespace VMS.Desafio.Telemedicina.Controllers
{
    
    [Route("api/v1/registration")]
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;
        private readonly IMediator _mediator;

        public RegistrationController(ILogger<RegistrationController> logger,
            IMediator mediator)
        {
            _logger = logger; 
            _mediator = mediator;
        }
        
        [HttpGet("registrations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll_RegistrationAsync([FromServices] IRegistrationRepository repository)
        {
            _logger.LogDebug("[REGISTRATION] - Starting getting person data");

            var result = await repository.GetAllAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        
        [HttpGet("registration/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRegistrationByIdAsync([FromRoute][Required] Guid id, 
            [FromServices] IRegistrationRepository repository, 
            CancellationToken cancellationToken)
        {
            _logger.LogDebug("[REGISTRATION] - Starting getting registration data by Id");
            
            var result = await repository.GetByIdAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }
        
        
        [HttpPost("add-registration")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(RegistrationOutPut))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostRegistrationAsync([FromBody] RegistrationInput registration, 
            [FromServices] IRegistrationRepository repository,
            CancellationToken cancellationToken)
        {
            _logger.LogDebug("[REGISTRATION] - Add registration data");    
            var result = await _mediator.Send(registration, cancellationToken);           
            
            return Ok();
        }
         
        [HttpPost("delete-registration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CancelRegistration([FromRoute][Required] Guid id, CancellationToken cancellationToken)
        {
            _logger.LogDebug("[REGISTRATION] - Deleting registration data");

            return Ok();
        }
    }
}
