using Microsoft.EntityFrameworkCore;

namespace InsurancePolicyApi.Models
{
    public class PolicyContext : DbContext
    {
        public PolicyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Policy> Policies { get; set; }
    }
}
