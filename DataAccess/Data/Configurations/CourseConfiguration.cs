using CareerBuild.DataAccess.Models.CourseModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Data.Configurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(x => x.CourseId);// for PK

			//For the conversion of the Enum
			builder.Property(c => c.DifficultyLevel)
				.HasConversion(cd => cd.ToString(),
				cd => Enum.Parse<DifficultyLevel>(cd));
		}
	}
}
