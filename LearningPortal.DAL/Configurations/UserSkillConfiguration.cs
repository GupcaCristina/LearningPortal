using Microsoft.EntityFrameworkCore;
using LearningPortal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPortal.DAL.Configurations
{
    public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> modelBuilder)
        {
            modelBuilder
                .HasKey(t => (new { t.ApplicationUserId, t.SkillId }));

            modelBuilder
                .HasOne(pt => pt.Skill)
                .WithMany(pt => pt.UserSkills)
                .HasForeignKey(pt => pt.SkillId);

            modelBuilder
                .HasOne(pt => pt.ApplicationUser)
                .WithMany(pt => pt.UserSkills)
                .HasForeignKey(pt => pt.ApplicationUserId);
        }
    }
}
