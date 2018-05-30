using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration.Json;


namespace LearningPortal.DAL.EF
{
    class TempLearningPortalContextFactoryIDesignTimeDbContextFactory : IDesignTimeDbContextFactory<LearningPortalContext>
    {
        public LearningPortalContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<LearningPortalContext>();
            DbContextOptions<LearningPortalContext> options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            LearningPortalContext learningPortalContext = Activator.CreateInstance(typeof(LearningPortalContext), new object[] { options }) as LearningPortalContext; //new LearningPortalContext(options);
            return learningPortalContext;
        }
    }
}
