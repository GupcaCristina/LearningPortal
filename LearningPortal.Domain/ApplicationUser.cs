using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace LearningPortal.Domain
{

    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(1)]
        public string Gender { get; set; }
        [MaxLength(100)]
        public string AboutMe { get; set; }
        public DateTime BirthDate { get; set; }
        public string Occupation { get; set; }
        public DateTime JoinDate { get; set; }
        public Address Address { get; set; }
        public byte[] ProfileImage { get; set; }

        public List<EducationalQualification> Education = new List<EducationalQualification>();
        public List<UserHobbie> UserHobbies { get; set; }  = new List<UserHobbie>();
        public List<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
    }
}
