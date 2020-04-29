using Microsoft.EntityFrameworkCore;

namespace Health.API.Models.Context
{
    public class HealthContext : DbContext
    {
        public HealthContext(DbContextOptions<HealthContext> options) : base(options)
        {

        }
        public DbSet<Ailment> Ailments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medication> Medications { get; set; }
    }

    // dotnet (.Net Core CLI)                                                  Visual Studio
    // ---------------------------------------------------------------------   ---------------------------------------
    // dotnet-ef migrations add InitialCreate -o Models/Migrations             Add-Migration InitialCreate   
    // dotnet-ef database update                                               Update-Database
    // dotnet ef migrations remove                                             Remove-Migration
    // dotnet ef migrations script                                             Script-Migration
    
}