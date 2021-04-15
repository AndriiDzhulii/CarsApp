using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Models.Entities
{
	[Table("car_attribute")]
	public class CarAttribute : EntityBase
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("attribute_id")]
		public override int Id { get; set; }

		[Column("attribute_name")]
		public string Name { get; set; }

		[Column("attribute_type_id")]
		public int TypeId { get; set; }

		[ForeignKey("TypeId")]
		public CarAttributeType Type { get; set; }
	}
}
