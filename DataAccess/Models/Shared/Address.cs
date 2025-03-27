using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerBuild.DataAccess.Models.Shared
{
	[Owned] // to represent that it's will not be table on its one
	public class Address
	{
		public string Country { get; set; } = null!;
		public string City { get; set; } = null!;
		public string Region { get; set; } = null!;
	}
}
