using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Contexts;

namespace VMS.Desafio.Telemedicina.Domain.Aggregates.Registration
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly IConfiguration _configuration;
        public RegistrationRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task AddAsync(Registration register)
        { 
            using (DatabaseContext db = new GetContext(_configuration).GetContextDetail())
            {
                db.AddAsync(register);
                db.SaveChanges();
            }
            return Task.CompletedTask;
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Registration>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Registration> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            throw new NotImplementedException();
        }
    }
}
