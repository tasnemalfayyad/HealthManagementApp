using Microsoft.EntityFrameworkCore;
using HealthDomain.Entities;

namespace HeathData
{
    public class HealthManagementAppDbContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment>  Appointments { get; set; }
        public DbSet<Billing>Billings { get; set; } 
        public DbSet<Clinician> Clinicians {  get; set; }
        public DbSet<Patient> Patients {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=M_App_Health");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billing>(entity =>
            {
                entity.Property(e => e.Amount)
                      .HasColumnType("decimal(18, 2)"); // تحديد النوع والدقة والمقياس
            });
    



        }





    }
}
