using DLWMS.Data;

using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server=192.168.1.32, 1433;Initial Catalog=DLWMS;User ID=admin;Password=password;Persist Security Info=False;Encrypt=True;
            optionsBuilder.UseSqlite(konekcijskiString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Uloge)
                .WithMany(u => u.Studenti)
                .UsingEntity(t => t.ToTable("StudentiUloge"));
        }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi{ get; set; }
        public DbSet<Uloga> Uloge { get; set; }
        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<VrstaUplate> VrsteUplata { get; set; }
        public DbSet<StudentUplata> StudentiUplate { get; set; }
        public DbSet<StudentPredmet> StudentiPredmeti { get; set; }








    }
}
