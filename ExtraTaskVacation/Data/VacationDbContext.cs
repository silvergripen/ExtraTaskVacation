using ExtraTaskVacation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VacationTaskUppgift.Models;

namespace ExtraTaskVacation.Data
{
    public class VacationDbContext : IdentityDbContext<IdentityUser>
    {
        public VacationDbContext(DbContextOptions<VacationDbContext> options) : base(options)
        {

        }

        public DbSet<CurrentRequestsModel> CurrentRequests { get; set; }
        public DbSet<PersonelModel> Personels { get; set; }
        public DbSet<RequestVacationModel> RequestVacations { get; set; }
        public DbSet<VacationStatusModel> VacationStatuses { get; set; }
        public DbSet<VacationTypeModel> VacationTypes { get; set; }



    }
}
