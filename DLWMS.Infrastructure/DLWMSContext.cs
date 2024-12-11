using DLWMS.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Server=192.168.1.32, 1433;
            //Initial Catalog=DLWMS;
            //User ID=admin;
            //Password=password;
            //Persist Security Info=False;
            //Encrypt=True;

            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Student> Studenti { get; set; }



    }
}
