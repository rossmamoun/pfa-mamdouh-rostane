using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SyndicPfaApp.Models;

namespace SyndicPfaApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Ascenseur> Ascenseurs { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Resident> Residents { get; set; }
    }
}
