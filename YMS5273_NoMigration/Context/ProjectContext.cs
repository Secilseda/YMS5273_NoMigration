using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMS5273_NoMigration.Models;

namespace YMS5273_NoMigration.Context
{
	public class ProjectContext:DbContext
	{
		public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<AppUser> Users { get; set; }
	}
}
