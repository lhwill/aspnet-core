using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using StudentMS.Authorization.Roles;
using StudentMS.Authorization.Users;
using StudentMS.MultiTenancy;
using StudentMS.Models;

namespace StudentMS.EntityFrameworkCore
{
    public class StudentMSDbContext : AbpZeroDbContext<Tenant, Role, User, StudentMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StudentMSDbContext(DbContextOptions<StudentMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
