using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Application.UseCases.Registration;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;

namespace VMS.Desafio.Telemedicina.Infrastructure.Mappings
{
    public class CreateRegistrationMapper : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("Nome_Usuario");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("Email_Usuario");

        }

        #region Mapping fields
        //public Registration MapToCreatedRegistration(this RegistrationInput input)
        //{
        //    if (input == null) return null;

        //    var result = new Registration(
        //        registrationId: Guid.NewGuid(),
        //        name: input.Name,
        //        email: input.Email,
        //        type: input.RegistrationType,
        //        createAt: DateTime.Now
        //        );

        //    return result;
        //}
        #endregion
    }
}
