using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Transactions;

namespace Demo.Models
{
	public class TransactionDbContext:DbContext
	{
		public TransactionDbContext(DbContextOptions<TransactionDbContext> options):base(options)
		{




		}
		public DbSet<Transaction> Transactions { get; set; }
	}
}
 