using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Models.JobModel
{
	public class Job
	{
		public int JobId { get; set; }
		public string JobTitle { get; set; } = null!;
		public string Description { get; set; } = null!;
		public Address JobLocation { get; set; } = null!;
		public DateTime PostedAt { get; set; }
		public DateTime ExpiresAt { get; set; }
		public EmploymentType EmploymentType { get; set; }

		//Represent salary range
		public decimal MinSalary { get; set; }
		public decimal MaxSalary { get; set; }
	}
}
