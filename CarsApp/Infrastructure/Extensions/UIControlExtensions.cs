using System.Web.UI;

namespace CarsApp.Infrastructure.Extensions
{
	public static class UIControlExtensions
	{
		public static T FindControl<T>(this Control control, string id) where T : Control
		{
			return control.FindControl(id) as T;
		}
	}
}