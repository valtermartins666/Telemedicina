using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;

namespace VMS.Desafio.Telemedicina.Domain.Mappings
{
    internal class CreateRegistrationMapper : IEntityTypeConfiguration<Registration>
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
    }
}
