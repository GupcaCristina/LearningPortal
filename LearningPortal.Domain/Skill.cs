
using System.Collections.Generic;

namespace LearningPortal.Domain
{
    public class Skill:Entity<int>
    {
        public string Name { get; set; }
        public byte[] ProfileImage { get; set; }
        public List<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
    }
}
