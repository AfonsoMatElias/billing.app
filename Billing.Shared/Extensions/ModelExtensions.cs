using System.Collections.Generic;
using System.Linq;
public static class ModelExtensions
{
	/// <summary>
	/// Updates properties from a model to another
	/// </summary>
	public static T UpdateFrom<T>(this T destination, T source, HashSet<string> ignoreFields = null) where T : class
	{

		// If the source is null, just return the destination it self
		if (source == null)
			return destination;

		// Getting the obj type
		var typeDestination = destination.GetType();
		var typeSource = source.GetType();

		// Getting the props of the type
		var sourceProperties = typeSource.GetProperties();
		var destinationProperties = typeDestination.GetProperties();

		foreach (var property in sourceProperties)
		{
			// Checking if the property is on ignore list
			if (ignoreFields != null && ignoreFields.Contains(property.Name)) continue;

			var propValue = property.GetValue(source);

			// Verifying if the source isn't null and is diferent of the of the destination
			if (propValue is null)
				continue;

			typeDestination.GetProperty(property.Name).SetValue(destination, propValue);
		}

		return destination;
	}
}