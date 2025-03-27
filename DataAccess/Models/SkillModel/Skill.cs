using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Models.SkillModel
{
	public class Skill
	{
		[Key]
		public int SkillId { get; set; }
		public string Name { get; set; } = null!;
		public string? Category { get; set; }
		public string? Description { get; set; }
	}
}
