namespace Cars.Models.Models
{
	public class CarAttributeModel : BaseEntityModel
	{	
		public string Name { get; set; }

		public int TypeId { get; set; }

		public CarAttributeTypeModel Type { get; set; }
	}
}
