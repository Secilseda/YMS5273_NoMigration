using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YMS5273_NoMigration.Models
{
	[Table("Products")]
	public class Product:BaseEntity
	{
		[Required,MinLength(4)]
		public string Name { get; set; }
		[Required,MaxLength(255)]
		public string Description { get; set; }

		public decimal Price { get; set; }

		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }
	}
}
