using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor;

namespace VMS.Desafio.Telemedicina.Domain.Aggregates.Person.Interface
{
    public interface IPersonRepository<T> where T : class
    {
        Task AddAsync(DoctorCreate doctor);
        Task<T> GetByIdAsync(Guid id);
        Task DeleteByIdAsync(Guid id);
        Task<bool> ExistsByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
    }
}
