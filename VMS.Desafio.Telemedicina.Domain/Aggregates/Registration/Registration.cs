using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Desafio.Telemedicina.Domain.Aggregates.Enums;

namespace VMS.Desafio.Telemedicina.Domain.Aggregates.Registration
{
    public class Registration 
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreateAt { get; set; }

        public RegistrationType RegisterType { get; set; }        


        public Registration(Guid registrationId, 
            string name, 
            string email,            
            RegistrationType type,
            DateTime createAt
            )
        {
            Id = registrationId;
            Name= name;
            Email = email;
            RegisterType = type;
            CreateAt = createAt;
        }
    }
}
