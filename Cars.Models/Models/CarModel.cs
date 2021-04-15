namespace Cars.Models.Models
{
	public class CarModel : BaseEntityModel
	{
		public string Name { get; set; }

		public CarAttributeModel Engine { get; set; } = new CarAttributeModel();

		public CarAttributeModel Battery { get; set; } = new CarAttributeModel();

		public CarAttributeModel Manufacturer { get; set; } = new CarAttributeModel();

		public int MaxSpeed { get; set; }

		public int MaxSeats { get; set; }

		public CarModel()
		{

		}

		public CarModel(int engineId, int batteryId, int manufactorerId)
		{
			Engine.Id = engineId;
			Battery.Id = batteryId;
			Manufacturer.Id = manufactorerId;
		}
	}
}
