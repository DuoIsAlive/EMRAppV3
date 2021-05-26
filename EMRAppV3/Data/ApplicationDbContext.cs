
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace EMRAppV3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Models.ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Models.City> Citys { get; set; }
        public DbSet<Models.MedicalInfo> MedicalInfos { get; set; }
        public DbSet<Models.PatientInfo> PatientInfos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
