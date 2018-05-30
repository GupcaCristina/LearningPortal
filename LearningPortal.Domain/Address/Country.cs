using System.ComponentModel.DataAnnotations;

namespace LearningPortal.Domain
{
    public class Country:Entity<int>
    {
        [MaxLength(100)]
        public string Name { get; set; }

    }
}