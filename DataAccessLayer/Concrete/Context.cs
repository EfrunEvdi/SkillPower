using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLOCALDB; initial catalog = SkillPowerDB; integrated security = true;");
        }

        public DbSet<AboutHeader> AboutHeaders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<HomeComment> HomeComments { get; set; }
        public DbSet<HomeHeader> HomeHeaders { get; set; }
        public DbSet<HomeProgram> HomePrograms { get; set; }
        public DbSet<HomeStep> HomeSteps { get; set; }
        public DbSet<ServicesAbout> ServicesAbouts { get; set; }
        public DbSet<ServicesFeatured> ServicesFeatureds { get; set; }
        public DbSet<ServicesHeader> ServicesHeaders { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
