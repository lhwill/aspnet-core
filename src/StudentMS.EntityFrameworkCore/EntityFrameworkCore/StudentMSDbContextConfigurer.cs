using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace StudentMS.EntityFrameworkCore
{
    public static class StudentMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StudentMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StudentMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
