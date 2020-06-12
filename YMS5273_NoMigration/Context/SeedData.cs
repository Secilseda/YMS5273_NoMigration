using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMS5273_NoMigration.Models;

namespace YMS5273_NoMigration.Context
{
	public class SeedData
	{
		//test datasıdır. Projelerimde olacak!
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context=new ProjectContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
			{
				if (context.Categories.Any())//varsa eklemeyecek. 
					//diğer entity'ler için düzenleme yapmak lazım if'in yanına( && context.Products.Any())(product)
				{
					return;
				}
				context.Categories.AddRange(
					new Category
					{
						Name="American Footbal Equipment",
						Description= "American Footbal Equipment"
					},
				new Category
				{
					Name = "Mix Martial Arts Equipment",
					Description = "Mix Martial Arts Equipment",
				},
				new Category
				{
					Name = "Boxing Equipment",
					Description = "Boxing Equipment",
				}
				);
				context.SaveChanges();
				//context.Products.AddRange(
				//	new Product
				//	{
				//		Name = "Boxing gloves",
				//		Description = "Boxing gloves",
				//		Price = 18,
				//		CategoryId = 6
				//	}
				//	);

			}
		}
	}
}
