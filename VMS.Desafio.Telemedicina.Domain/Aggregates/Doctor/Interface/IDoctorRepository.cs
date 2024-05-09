using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface
{
    public interface IDoctorRepository
    {
        Task AddAsync(DoctorCreate doctor);
        Task<DoctorCreate> GetByIdAsync(Guid id);
        Task DeleteByIdAsync(Guid id);
        Task<bool> ExistsByIdAsync(Guid id);    
        Task<List<DoctorCreate>> GetAllAsync();

    }
}
