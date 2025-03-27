using CareerBuild.DataAccess.Data.Contexts;
using DataAccess.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Data.Repositories
{
	public class GenericRepository<T>(CareerBuildDbContext _dbContext)
		: IGenericRepository<T> where T : class
	{
		// int as return type returns to number of the affected rows
		public int Add(T entity)
		{
			_dbContext.Add(entity);
			return _dbContext.SaveChanges();
		}

		public IEnumerable<T> GetAll(bool isTracking = false)
		{
			//track is overhead so we make sure we need it to apply change
			//otherwise no tracking is better option
			if (isTracking)
			{
				return _dbContext.Set<T>().ToList();
			}
			return _dbContext.Set<T>().AsNoTracking().ToList();
		}

		public T? GetById(int id)
		{
			//first search locally in by PK 
			//it element is not found send query to db to gets it
			return _dbContext.Find<T>(id);
		}

		public int Remove(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
			return _dbContext.SaveChanges();
		}

		public int Update(T entity)
		{
			_dbContext.Set<T>().Update(entity);

			return _dbContext.SaveChanges();
		}
	}
}
