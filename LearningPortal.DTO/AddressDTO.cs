namespace LearningPortal.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string StreetNumber { get; set; }
        public StreetDTO Street { get; set; }
    }
}