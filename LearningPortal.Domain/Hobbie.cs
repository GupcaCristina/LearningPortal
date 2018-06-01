using System.Collections.Generic;

namespace LearningPortal.Domain
{
    public class Hobbie:Entity<int>
    {
        public string Name { get; set; }
        public byte[] ProfileImage { get; set; }
        public List<UserHobbie> UserHobbies { get; set; } = new List<UserHobbie>();
    }
}