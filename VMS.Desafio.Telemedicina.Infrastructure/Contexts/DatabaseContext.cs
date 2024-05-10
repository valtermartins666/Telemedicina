using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;
using VMS.Desafio.Telemedicina.Infrastructure.Mappings;

namespace VMS.Desafio.Telemedicina.Infrastructure.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) 
            : base(opt) { }

        public DbSet<Registration> Registrations { get; set; }

        protected void OnCreateModel(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CreateRegistrationMapper());
            base.OnModelCreating(builder);
        }
    }
}
