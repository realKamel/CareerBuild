using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Contexts
{
	//To make this work with DI
	public class CareerBuildDbContext(DbContextOptions<CareerBuildDbContext> contextOptions)
		: DbContext(contextOptions)
	{
		//connecting to Db is done in program.cs and connection string in the appsettings.json
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// this only targets ApplicationDbContext Assembly only
			// this apply Fluent API Configurations Automatically
			// using C# Reflection
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(CareerBuildDbContext).Assembly);
		}

		//We add DBSet<T> Here to able to interact with it
	}
}
