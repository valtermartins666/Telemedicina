using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Infrastructure.DTO.Enum;

namespace VMS.Desafio.Telemedicina.Infrastructure.DTO.Registration
{
    public class RegistrationRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType type { get; set; }
        public DateTime CreateAt { get; set; }
        
    }
}
