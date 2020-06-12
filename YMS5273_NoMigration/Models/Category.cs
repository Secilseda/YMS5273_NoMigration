using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YMS5273_NoMigration.Models
{
	[Table("Categories")]
	public class Category:BaseEntity
	{
		[Required,MinLength(3)]
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
