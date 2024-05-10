
using Microsoft.Extensions.Logging;
using System.Text.Json;
using VMS.Desafio.Telemedicina.Application.UseCases.Validators;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;

namespace VMS.Desafio.Telemedicina.Application.UseCases.Registration
{
    public class RegistrationUseCase : IRegistrationUseCase
    {
        private readonly ILogger<RegistrationUseCase> _logger;
        private readonly IRegistrationRepository _registration;
        public RegistrationUseCase(ILogger<RegistrationUseCase> logger,
            IRegistrationRepository registration)
        {
            _logger = logger;
            _registration = registration;


        }
        public async Task<RegistrationOutPut> Handle(RegistrationInput input, CancellationToken cancellationToken)
        {
            var output = new RegistrationOutPut();
            try
            {
                _logger.LogInformation("Create new registration {register}", JsonSerializer.Serialize(input));

                var validation = await new RegistrationValidator().ValidateAsync(input);

                if (!validation.IsValid) {
                    var errors = string.Join("; ", validation.Errors.Select(x => x.ErrorMessage));
                    _logger.LogWarning("Invalid input: {error}", errors);

                    output.AddErrorMessage($"Invalid input: {errors}");
                    return output;
                }

                var emailExists = await _registration.ExistsByEmailAsync(input.Email);
                if (emailExists)
                {
                    _logger.LogInformation("Email already exists");
                    output.AddMessage("Email already exists");
                    return output;
                }

                //var createRegistration = input.MapToCreatedRegistration();

                output.AddMessage("Success");
                return output;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
