using Microsoft.EntityFrameworkCore;
using DoctorApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApplication.DataAccessLayer
{
    internal class AppDbContext : DbContext
    {
      public DbSet<Doctor> doctors { get; set; }

        public string ConnectionStrings { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionStrings = "Server=DESKTOP-2KVE13T; Database=EFCoreDb; Trusted_Connection=True; TrustServerCertificate=yes";
            optionsBuilder.UseSqlServer(ConnectionStrings);
        }
    }
}
