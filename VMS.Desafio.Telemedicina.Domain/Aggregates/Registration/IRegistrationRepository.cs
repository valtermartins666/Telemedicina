using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor;

namespace VMS.Desafio.Telemedicina.Domain.Aggregates.Registration
{
    //public interface IRegistrationRepository<T> where T : class
    public interface IRegistrationRepository
    {
        Task AddAsync(Registration register);
        Task<Registration> GetByIdAsync(Guid id);
        Task DeleteByIdAsync(Guid id);
        Task<bool> ExistsByIdAsync(Guid id);
        Task<bool> ExistsByEmailAsync(string email);
        Task<List<Registration>> GetAllAsync();
    }
}
