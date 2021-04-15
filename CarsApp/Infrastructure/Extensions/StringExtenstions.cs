namespace CarsApp.Infrastructure.Extensions
{
	public static class StringExtenstions
	{
		public static int ToInt(this string value)
		{
			return int.Parse(value);
		}
	}
}