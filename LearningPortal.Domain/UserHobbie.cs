namespace LearningPortal.Domain
{
    public class UserHobbie
    {     
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int HobbieId { get; set; }
        public Hobbie Hobbie { get; set; }        
    }
}
