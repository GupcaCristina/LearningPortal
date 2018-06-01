using LearningPortal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningPortal.Web.Models.UserViewModels
{
    public class UserDetailsViewModel
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string AboutMe { get; set; }
        public DateTime BirthDate { get; set; }
        public string Occupation { get; set; }
        public DateTime JoinDate { get; set; }
        public AddressDTO Address { get; set; }
        public byte[] ProfileImage { get; set; }

        public List<EducationalQualificationDTO> Education = new List<EducationalQualificationDTO>();
        public List<LookupDTPO> Hobbies { get; set; } = new List<LookupDTPO>();
        public List<LookupDTPO> Skills { get; set; } = new List<LookupDTPO>();
    }
}
