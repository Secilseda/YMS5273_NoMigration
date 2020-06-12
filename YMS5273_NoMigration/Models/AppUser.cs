using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YMS5273_NoMigration.Models
{
	[Table("Users")]
	public class AppUser:BaseEntity
	{
		[Required,MaxLength(50)]
		public string FirstName { get; set; }

		[Required, MaxLength(50)]
		public string LastName { get; set; }
	}
}
