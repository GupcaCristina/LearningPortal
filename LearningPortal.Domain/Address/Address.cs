using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningPortal.Domain
{
    public class Address : Entity<int>
        
    {
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(10)]
        public string StreetNumber { get; set; }

        [ForeignKey("Street")]
        public int StreetID { get; set; }
        public Street Street { get; set; }
    }
}