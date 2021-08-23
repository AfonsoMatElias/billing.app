using System.Linq;
using System.Threading.Tasks;

namespace Billing.Shared.Extensions
{
    public static class ModelExtensions
    {
        /// <summary>
        /// Updates properties from a model to another
        /// </summary>
        public static T UpdateFrom<T>(this T destination, T source, string[] ignore = null) where T : class
        {
            // Getting the obj type
            var typeDestination = destination.GetType();
            var typeSource = source.GetType();

            // Getting the props of the type
            var sourceProperties = typeSource.GetProperties();
            var destinationProperties = typeDestination.GetProperties();

            foreach (var property in sourceProperties)
            {
                // Checking if the property is on ignore list
                if (ignore != null && ignore.Any(x => x.ToLower() == property.Name.ToLower())) continue;

                var propValue = property.GetValue(source);
                // Verifying if the source isn't null and is diferent of the of the destination
                if (propValue != null)
                    typeDestination.GetProperty(property.Name).SetValue(destination, propValue);
            }

            return destination;
        }
    }
}