using MediatR;

namespace VMS.Desafio.Telemedicina.Application.UseCases.Registration
{
    public interface IRegistrationUseCase : IRequestHandler<RegistrationInput, RegistrationOutPut>
    {
    }
}
