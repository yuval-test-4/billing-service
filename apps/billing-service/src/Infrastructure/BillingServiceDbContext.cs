using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BillingService.Infrastructure;

public class BillingServiceDbContext : IdentityDbContext<IdentityUser>
{
    public BillingServiceDbContext(DbContextOptions<BillingServiceDbContext> options)
        : base(options) { }
}
