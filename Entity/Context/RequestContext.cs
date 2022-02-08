using Entity.Config;
using Entity.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Context
{
    public class RequestContext : IdentityDbContext<User, Role, Guid>
    {
        public RequestContext(DbContextOptions<RequestContext> ops) : base(ops)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin").HasKey(x => new { x.UserId, x.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserToken").HasKey(x => new { x.UserId, x.LoginProvider });
            //modelBuilder.Seed();

            modelBuilder.ApplyConfiguration(new RequestConfig());

            /* modelBuilder
                 .Entity<Request>()
                 .Property(e => e.Class)
                 .HasConversion(
                     v => v.ToString(),
                     v => (ClassList)Enum.Parse(typeof(ClassList), v));

             modelBuilder
                 .Entity<Request>()
                 .Property(e => e.LeaveType)
                 .HasConversion(
                     v => v.ToString(),
                     v => (LeaveTypeList)Enum.Parse(typeof(LeaveTypeList), v));
             //modelBuilder.ApplyConfiguration(new CityConfig());*/

        }
        public DbSet<Request> requests { get; set; }
    }
}
