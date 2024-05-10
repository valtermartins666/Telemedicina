using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Application.UseCases.Registration;

namespace VMS.Desafio.Telemedicina.Application.UseCases.Validators
{
    public class RegistrationValidator : AbstractValidator<RegistrationInput>
    {
        public RegistrationValidator()
        {
            ValidateName();
            ValidateEmail();
        }

        private void ValidateName()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
        private void ValidateEmail()
        {
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}
