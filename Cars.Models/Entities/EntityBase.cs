using System.ComponentModel.DataAnnotations;

namespace Cars.Models.Entities
{
	public abstract class EntityBase
	{
		[Key]
		public virtual int Id { get; set; }
	}
}
