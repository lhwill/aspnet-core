using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StudentMS.Configuration;
using StudentMS.Web;

namespace StudentMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StudentMSDbContextFactory : IDesignTimeDbContextFactory<StudentMSDbContext>
    {
        public StudentMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StudentMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StudentMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StudentMSConsts.ConnectionStringName));

            return new StudentMSDbContext(builder.Options);
        }
    }
}
