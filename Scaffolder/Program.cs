using System;
using System.IO;
using System.Linq;
using Scaffolder.Scaffold;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Scaffolder
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsFields = typeof(Options).GetFields();
            Console.WriteLine("... Welcome to Scaffolder ...");
        Begining:
            Console.WriteLine(@"");

            for (int i = 0; i < optionsFields.Count(); i++)
            {
                if (i == 0) continue;
                Console.WriteLine($@"-> {i} {optionsFields[i].Name}");
            }
            Console.WriteLine(@"Choose an option above: ");

            Options option = SharedMethods.KeyConverter<Options>();

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
                SharedMethods.ChangeColor(ConsoleColor.Red, () =>
                {
                    Console.WriteLine("Unavailable option, try again!");
                });
            }

            goto Begining;

        Ending:

            Console.WriteLine("\nThanks a lot!!! ;-)");
            Console.WriteLine("\nPress Any Key in Keyboard to Close the Window.");
            Console.ReadKey();
        }

        enum Options
        {
            Controller = 1,
            Service,
            ViewModel,
            Exit,
        }
    }

    public class SharedMethods
    {
        public static readonly string GlobalRootPath = BackFolder(AppDomain.CurrentDomain.BaseDirectory, 5); // Project Name
        public static string ModelsPath = Path.Combine(GlobalRootPath, "Billing.Service", "Models");
        public static List<(string, string)> Models = new List<(string, string)>();
        public static bool IsLinux { get => RuntimeInformation.IsOSPlatform(OSPlatform.Linux); }

        static string BackFolder(string path, int n)
        {
            for (int i = 0; i < n; i++) path = Directory.GetParent(path).FullName;
            return path;
        }

        public static void ChangeColor(ConsoleColor color, Action action)
        {
            Console.ForegroundColor = color;
            action.Invoke();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string PascalCase(string str)
        {
            string text = "";
            bool upper = false;
            bool forceUpper = false;

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                var isNumber = ((int)c >= 48 && (int)c <= 57);
                var ch = str[i].ToString();
                var chUpper = ch.ToUpper();

                if (i == 0)
                {
                    upper = false;
                    forceUpper = true;
                }

                if (ch == "_")
                {
                    forceUpper = true;
                    continue;
                }

                if (ch == chUpper && !upper || forceUpper)
                {
                    upper = true;
                    forceUpper = false;
                    text += chUpper;
                }
                else if (ch == chUpper && upper)
                {
                    text += ch.ToLower();
                }
                else
                {
                    upper = false;
                    text += ch;
                }

                if (isNumber) forceUpper = true;

            }

            return text;
        }

        public static T KeyConverter<T>() where T : Enum
        {
            // Getting the pressed key
            var op = Console.ReadKey();
            Console.WriteLine(@"");

            try
            {
                return (T)Enum.Parse(typeof(T), op.KeyChar.ToString());
            }
            catch (Exception ex)
            {
                SharedMethods.ChangeColor(ConsoleColor.Red, () => Console.WriteLine($"Invalid Option!. Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}"));
                Console.ReadKey();
                return default(T);
            }
        }

        public static bool ModelExists(string name)
        {
            if (!Models.Any(m => m.Item1 == name))
            {
                SharedMethods.ChangeColor(ConsoleColor.Red, () => Console.WriteLine("Class not found."));
                return false;
            }
            return true;
        }

        public static List<(string, string)> LoadModels()
        {
            if (!Models.Any())
                Models = Directory.GetFiles(ModelsPath).Select(s =>
                {
                    var fileInfo = new FileInfo(s);
                    return (fileInfo.Name.Replace(".cs", ""), fileInfo.FullName);
                }).ToList();
            return Models;
        }

    }
}