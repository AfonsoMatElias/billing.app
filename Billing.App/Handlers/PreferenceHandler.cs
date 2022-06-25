using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Billing.Shared.Helpers;
using Newtonsoft.Json;

namespace Billing.App.Handlers
{
	public class PreferenceHandler
	{

		private Dictionary<string, Dictionary<string, object>> data = new Dictionary<string, Dictionary<string, object>>();
		private string path;

		public PreferenceHandler()
		{
			this.path = IoC.Configuration["Preferences"];

			// Create file if it does not exists
			if (!File.Exists(path)) File.WriteAllText(path, "{}");

			// Reading all the data
			var content = File.ReadAllText(path);

			// Converting to the object
			this.data = JsonConvert
				.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(content);
		}

		public bool HasPreferences(string user)
		{
			return this.GetUserPreferences(user) != null;
		}

		public Dictionary<string, object> InitPreferences(string user)
		{
			// Creating new preferences for the user
			Dictionary<string, object> pref = new Dictionary<string, object>
			{
				{"messagePopup", true},
				{"notificationPopup", true},
				{"cashBoxOpenCloseConfirmation", false},
				{"darkMode", false},
			} as Dictionary<string, object>;

			// Adding to the object
			this.data.TryAdd(user, pref);

			return pref;
		}

		private Dictionary<string, object> GetUserPreferences(string user)
		{
			// Getting the value from the storage
			return this.data.GetValueOrDefault(user);
		}

		public async Task<Dictionary<string, object>> Get(string user)
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
			pref[name] = Convert.ChangeType(value, pref[name].GetType());

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
			await File.WriteAllTextAsync(this.path, JsonConvert.SerializeObject(this.data));
		}
	}
}