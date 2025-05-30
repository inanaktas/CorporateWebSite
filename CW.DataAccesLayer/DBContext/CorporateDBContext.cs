using CW.DataAccesLayer.DBModels;
using Microsoft.EntityFrameworkCore;

namespace CW.DataAccesLayer.DBContext
{
    public class CorporateDBContext : DbContext
    {
        public CorporateDBContext()
        {

        }

        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Career> Careers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<ApplicationSkill> ApplicationSkills { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server = "localhost";
            string dataSource = "AKTAS\\SQLEXPRESS";
            string dataBaseName = "CorporateDB";

            optionsBuilder.UseSqlServer($"Server={server};Data Source={dataSource};Initial Catalog={dataBaseName}; Trusted_Connection=True; TrustServerCertificate=True");
        }


        // İlişkili Tablo İçin Yazıldı
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationSkill>()
                .HasKey(x => new { x.ApplicationId, x.SkillId });

            modelBuilder.Entity<ApplicationSkill>()
                .HasOne(x => x.Application)
                .WithMany(a => a.ApplicationSkills)
                .HasForeignKey(x => x.ApplicationId);

            modelBuilder.Entity<ApplicationSkill>()
                .HasOne(x => x.Skill)
                .WithMany(s => s.ApplicationSkills)
                .HasForeignKey(x => x.SkillId);
        }

    }
}
