using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Billing.Shared.Helpers;
using Newtonsoft.Json;

namespace Billing.App.Handlers
{
	public class PreferenceItem
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public object Value { get; set; }
	}

	public class PreferenceHandler
	{
		private Dictionary<string, Dictionary<string, PreferenceItem>> data = new Dictionary<string, Dictionary<string, PreferenceItem>>();

		private string path;
		private string defaultPath;

		public PreferenceHandler()
		{
			this.path = IoC.Configuration["Preferences"];
			this.defaultPath = IoC.Configuration["DefaultPreferences"];

			if (!File.Exists(this.defaultPath))
				throw new AppException("Default Preferences file not found", false, 500);

			// Create file if it does not exists
			if (!File.Exists(path)) File.WriteAllText(path, "{}");

			// Reading all the data
			var content = File.ReadAllText(path);

			// Converting to the object
			this.data = JsonConvert
				.DeserializeObject<Dictionary<string, Dictionary<string, PreferenceItem>>>(content);
		}

		public bool HasPreferences(string user)
		{
			return this.GetUserPreferences(user) != null;
		}

		public Dictionary<string, PreferenceItem> InitPreferences(string user)
		{
			var newPreference = JsonConvert
				.DeserializeObject<Dictionary<string, PreferenceItem>>(
					File.ReadAllText(this.defaultPath)
			);

			// Adding to the object
			this.data.TryAdd(user, newPreference);

			return newPreference;
		}

		private Dictionary<string, PreferenceItem> GetUserPreferences(string user)
		{
			// Getting the value from the storage
			return this.data.GetValueOrDefault(user);
		}

		public async Task<Dictionary<string, PreferenceItem>> Get(string user)
		{
			// Getting user preferences
			var pref = this.GetUserPreferences(user);

			// Resolving the value 
			return await Task.FromResult(pref);
		}

		public async Task Set(string user, string name, string value)
		{
			// Getting user preferences
			var pref = this.GetUserPreferences(user);

			// Checking if exists
			if (pref == null)
			{
				// Creating new preferences for the user
				pref = this.InitPreferences(user);
			}

			// Setting the wanted value
			var item = pref[name];
			item.Value = Convert.ChangeType(value, item.Value.GetType());

			await Task.FromResult(0);
		}

		public async Task RemoveUser(string user)
		{
			// Getting user preferences
			var pref = this.GetUserPreferences(user);

			// Checking if exists
			if (pref == null)
				return;

			this.data.Remove(user);

			await Task.FromResult(0);
		}

		public async Task Save()
		{
			// Saving all the changes
			await File.WriteAllTextAsync(this.path,
				JsonConvert.SerializeObject(
					this.data,
					Formatting.Indented
				)
			);
		}
	}
}