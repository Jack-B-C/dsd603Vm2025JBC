using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dsd603Vm2025JBC.Models;

namespace dsd603Vm2025JBC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dsd603Vm2025JBC.Models.StaffNames> StaffNames { get; set; } = default!;
        public DbSet<dsd603Vm2025JBC.Models.Visitors> Visitors { get; set; } = default!;
    }
}
