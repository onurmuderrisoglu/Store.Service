using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
	public class StoreDbContext:DbContext
	{
		public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options) { }
		//public override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//}
		public DbSet<Products> Products { get; set; }
	}
}
