using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Models.Entities
{
	[Table("car")]
	public class Car : EntityBase
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("car_id")]
		public override int Id { get; set; }

		[Column("car_name")]
		public string Name { get; set; }

		[Column("engineId")]
		public int EngineId { get; set; }

		[ForeignKey("EngineId")]
		public CarAttribute Engine { get; set; }

		[Column("batteryId")]
		public int BatteryId { get; set; }

		[ForeignKey("BatteryId")]
		public CarAttribute Battery { get; set; }

		[Column("manufacturerId")]
		public int ManufacturerId { get; set; }

		[ForeignKey("ManufacturerId")]
		public CarAttribute Manufacturer { get; set; }

		[Column("max_speed")]
		public int MaxSpeed { get; set; }

		[Column("max_seats")]
		public int MaxSeats { get; set; }
	}
}
