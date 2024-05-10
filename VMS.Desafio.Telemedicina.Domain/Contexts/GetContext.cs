using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Desafio.Telemedicina.Domain.Contexts
{
    public class GetContext
    {
        private readonly IConfiguration _configuration;
        public GetContext(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public DatabaseContext GetContextDetail()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString(""));
            DatabaseContext dbContext = new DatabaseContext(optionsBuilder.Options);

            return dbContext;

        }
       
    }
}
