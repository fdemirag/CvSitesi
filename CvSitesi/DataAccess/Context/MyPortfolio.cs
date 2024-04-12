using CvSitesi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CvSitesi.DataAccess.Context
{
    public class MyPortfolio:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; initial catalog=MyPortfolio; integrated security=true");
        }

        public DbSet<About>Abouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
