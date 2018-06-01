
using LearningPortal.DAL.Configurations;
using LearningPortal.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LearningPortal.DAL.EF

{
    public class LearningPortalContext :IdentityDbContext<ApplicationUser>
    {
        public DbSet<EducationalQualification> EducationalQualifications { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<UserHobbie> UserHobbies{ get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }


        public LearningPortalContext(DbContextOptions<LearningPortalContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserHobbieConfiguration());
            modelBuilder.ApplyConfiguration(new UserSkillConfiguration());
        }
    }
}