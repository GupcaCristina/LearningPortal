using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningPortal.Domain
{
    public class Street : Entity<int>
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [ForeignKey("City")]
        public int CityID { get; set; }
        public City City { get; set; }
    }
}