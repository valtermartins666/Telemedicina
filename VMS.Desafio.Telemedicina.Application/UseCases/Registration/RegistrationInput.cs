using MediatR;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Enums;

namespace VMS.Desafio.Telemedicina.Application.UseCases.Registration
{
    public class RegistrationInput : IRequest<RegistrationOutPut>
    {
        public Guid Key { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public RegistrationType RegistrationType { get; set; }

    }
}
