using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Models.TrackModel
{
	public class Track
	{
		public int TrackId { get; set; }
		public string Name { get; set; } = null!; // required
		public string Description { get; set; } = null!; // required
		public TimeOnly EstimatedDuration { get; set; }
		public DifficultyLevel DifficultyLevel { get; set; }
	}
}
