
namespace LearningPortal.Domain
{
    public class  UserSkill
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}


