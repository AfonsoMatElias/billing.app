using System;
using System.IO;
using System.Linq;
using Scaffolder.Scaffold;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using Scaffolder.Models;

namespace Scaffolder
{
    class Program
    {

        public static ConfigProvider Config;

        static void Main(string[] args)
        {
            // Initializing the configurations
            Program.Config = new ConfigProvider();

            var optionsFields = typeof(Options).GetFields();
            Logger.Log("... Welcome to Scaffolder ...");
        Begining:
            Logger.Log(@"");

            for (int i = 0; i < optionsFields.Count(); i++)
            {
                if (i == 0) continue;
                Logger.Log($@"-> {i} {optionsFields[i].Name}");
            }
            Logger.Log(@"Choose an option above: ");

            Options option = Shared.KeyConverter<Options>();

            if (option == Options.Exit) goto Ending;
            var chosen = option.ToString();

            try
            {
                IEnumerable<Type> types = Assembly.GetExecutingAssembly().ExportedTypes;

                var type = types.FirstOrDefault(x => x.Name == $"{chosen}Scaffold");

                if (type == null)
                    throw new Exception("Not Found");

                // Instantiating the scaffolder class chosed
                Activator.CreateInstance(type);
            }
            catch
            {
                Logger.Error("Unavailable option, try again!");
            }

            goto Begining;

        Ending:

            Logger.Log("\nThanks a lot!!! ;-)");
            Logger.Log("\nPress Any Key in Keyboard to Close the Window.");
            Console.ReadKey();
        }

        enum Options
        {
            Controller = 1,
            Service,
            ViewModel,
            EFCore,
            Exit,
        }
    }

    public class Shared
    {
        public static readonly string GlobalRootPath = BackFolder(AppDomain.CurrentDomain.BaseDirectory, 5); // Project Name

        static string BackFolder(string path, int n)
        {
            for (int i = 0; i < n; i++) path = Directory.GetParent(path).FullName;
            return path;
        }

        public static T KeyConverter<T>() where T : Enum
        {
            // Getting the pressed key
            var op = Console.ReadKey();
            Logger.Log(@"");

            try
            {
                return (T)Enum.Parse(typeof(T), op.KeyChar.ToString());
            }
            catch (Exception ex)
            {
                Logger.Error($"Invalid Option!. Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
                Console.ReadKey();
                return default(T);
            }
        }

        public static bool ModelExists(string name)
        {
            if (!Program.Config.Models.Any(m => m.Name == name))
            {
                Logger.Error("Class not found.");
                return false;
            }
            return true;
        }

        public static string LoadTemplate(string templ, Configuration config, int count)
        {
            if (File.Exists(config.Template) && templ == null)
                templ = File.ReadAllText(config.Template);
            else if (count > 1)
                templ = File.ReadAllText(config.Template);

            return templ;
        }

        public static List<string> GetModelProperties(string filePath)
        {
            return File.ReadAllLines(filePath)
                       .Where(x => x.Trim().StartsWith("public") && x.Trim().Contains("get;"))
                       .ToList();
        }
    }
}