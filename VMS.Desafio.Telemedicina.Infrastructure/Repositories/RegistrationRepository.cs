using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Registration;

namespace VMS.Desafio.Telemedicina.Infrastructure.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        public Task AddAsync(Registration register)
        {
            throw new NotImplementedException();
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
    }
}
