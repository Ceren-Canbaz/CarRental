using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class CarRentalContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-TTOQ6J4\SQLEXPRESS;Database=CarRental;Trusted_Connection=true");
		}
		public DbSet<Car> Cars { get; set; }
		public DbSet<Brand> Brands{ get; set; }
		public DbSet<Color> Colors { get; set; }
	}
}
