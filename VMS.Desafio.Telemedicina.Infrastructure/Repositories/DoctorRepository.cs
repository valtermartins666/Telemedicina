using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Doctor.Interface;

namespace VMS.Desafio.Telemedicina.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public Task AddAsync(DoctorCreate doctor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DoctorCreate>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorCreate> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
