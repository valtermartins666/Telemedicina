using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Desafio.Telemedicina.Domain.Aggregates.Person
{
    public class Person
    {
        public Guid Id { get; set; }
        public string? PersonCode { get; set; }        
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }    
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsEnabled { get; set; }

        public Person(
                string? FirstName,
                string? LastName,
                string? Email,
                string? PhoneNumber,
                string? Address,
                string? City )
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
            Email = this.Email;
            PhoneNumber = this.PhoneNumber;
            Address = this.Address;
            City = this.City;                
        }

    }
}
