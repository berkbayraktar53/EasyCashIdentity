using Microsoft.EntityFrameworkCore;
using EasyCashIdentity.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework.Contexts
{
	public class DatabaseContext : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=EasyCashIdentityDb;Trusted_Connection=True;");
		}

		public DbSet<CustomerAccount> CustomerAccounts { get; set; }
		public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
	}
}