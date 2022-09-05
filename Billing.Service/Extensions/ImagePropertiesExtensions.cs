using System;

namespace Billing.Service.Extensions
{
	public static class ModelImagePropertiesExtension
	{
		public static string ToDownloadableUrl<TModel>(this TModel model) where TModel : Models.Base.ImageProperties
		{
			return $"/Download/{typeof(TModel).Name}/{model.UniqueName}";
		}

	}

	public static class DtoImagePropertiesExtension
	{
		public static string ToDownloadableUrl<TModel>(this TModel model) where TModel : Dto.Base.ImageProperties
		{
			var _name = typeof(TModel).Name;
			if (_name.EndsWith("Dto"))
				_name = _name.Substring(0, _name.Length - "Dto".Length);

			return $"/Download/{_name}/{model.UniqueName}";
		}
	}
}