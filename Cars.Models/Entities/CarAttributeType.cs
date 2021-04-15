using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Models.Entities
{
	[Table("car_attribute_type")]
	public class CarAttributeType : EntityBase
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("attribute_type_id")]
		public override int Id { get; set; }

		[Column("attribute_type_name")]
		public string Name { get; set; }
	}
}
