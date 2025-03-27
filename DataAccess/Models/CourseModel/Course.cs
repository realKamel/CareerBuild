using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Models.CourseModel
{
	public class Course
	{
		public int CourseId { get; set; }
		public string Name { get; set; } = null!;
		public decimal Price { get; set; }
		public string Description { get; set; } = null!;
		public string? CourseUrl { get; set; } // optional
		public TimeOnly Duration { get; set; }
		public string? ProviderName { get; set; }
		public DifficultyLevel DifficultyLevel { get; set; }
	}
}
