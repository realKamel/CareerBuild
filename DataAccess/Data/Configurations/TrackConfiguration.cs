using CareerBuild.DataAccess.Models.TrackModel;
using CareerBuild.DataAccess.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Data.Configurations
{
	public class TrackConfiguration : IEntityTypeConfiguration<Track>
	{
		public void Configure(EntityTypeBuilder<Track> builder)
		{
			builder.HasKey(d => d.TrackId);
			builder.Property(d => d.DifficultyLevel)
				.HasConversion(dl => dl.ToString(),
				(dl => Enum.Parse<DifficultyLevel>(dl)));
		}
	}
}
