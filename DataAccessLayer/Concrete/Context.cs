using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //metot yazmamız gereklidir. Parametresini de yazarız. (Db türünden optionsbuilder alırız)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GROOVYPRIMAT\\SQLEXPRESS;database=CoreProjeDB; integrated security=true");
        }

        //context sınıfı, EL'deki classlar
        //Çoğul olanlar SQL tablo isimleri 
        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocailMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
