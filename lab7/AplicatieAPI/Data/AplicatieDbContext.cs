using AplicatieAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicatie.API.Data 
{
	public class AplicatieDbContext : DbContext
	{
		public AplicatieDbContext(DbContextOptions options) : base(options)
		{
		}
public DbSet<Angajat> Angajati { get; set; }
	}
}





