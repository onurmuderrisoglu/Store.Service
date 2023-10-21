using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model
{
	[Table("Products")]
	public class Products
	{
		[Key, Required]
		public int Id{ get; set; }
		public int ProductCategory { get; set; }
		public string Name { get; set; }
	}
}