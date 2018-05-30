using System;
using System.ComponentModel.DataAnnotations;

namespace LearningPortal.Domain
{
    public class EducationalQualification:Entity<int>
    {
        [MaxLength(100)]
        public string SchoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(50)]
        public string Degree { get; set; }
        public string Description { get; set; }
    }
}