using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		int Add(T entity);
		IEnumerable<T> GetAll(bool isTracking = false);
		T? GetById(int id);
		int Remove(T entity);
		int Update(T entity);
	}
}
