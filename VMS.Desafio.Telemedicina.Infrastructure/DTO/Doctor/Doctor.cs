using VMS.Desafio.Telemedicina.Infrastructure.DTO.Enum;

namespace VMS.Desafio.Telemedicina.Infrastructure.DTO
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public MedicalSpecialties MedicalSpecialties { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }       


    }
}
