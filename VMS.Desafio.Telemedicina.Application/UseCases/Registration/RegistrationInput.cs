using MediatR;
using VMS.Desafio.Telemedicina.Domain;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Enums;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;

namespace VMS.Desafio.Telemedicina.Application.UseCases.Registration
{
    public class RegistrationInput : IRequest<RegistrationOutPut>
    {
        public Guid Key { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public RegistrationType RegistrationType { get; set; }


        public Domain.Aggregates.Registration.Registration MapToRegistration(RegistrationInput input) 
        { 
            return new Domain.Aggregates.Registration.Registration( 
                Name, 
                Email,                  
                DateTime.Now);
        }

    }
}
