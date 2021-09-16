using System;
using System.IO;
using System.Linq;

namespace Scaffolder.Scaffold
{
    public class ServiceScaffold : GenerationConditions
    {
        static string tail = "Service";

        static string tmpPathInput = Path.Combine(SharedMethods.GlobalRootPath, "Scaffolder", "tmp", "service.txt");
        static string itmpPathInput = Path.Combine(SharedMethods.GlobalRootPath, "Scaffolder", "tmp", "iservice.txt");

        static string tmpPathOutput = Path.Combine(SharedMethods.GlobalRootPath, "Billing.Service", "Services", "Implementations");
        static string itmpPathOutput = Path.Combine(SharedMethods.GlobalRootPath, "Billing.Service", "Services", "Interfaces");

        string tmp = File.Exists(tmpPathInput) ? File.ReadAllText(tmpPathInput) : null;
        string itmp = File.Exists(itmpPathInput) ? File.ReadAllText(itmpPathInput) : null;

        public void Generate(string name)
        {
            try
            {
                var filePath = Path.Combine(tmpPathOutput, $"{name}{tail}.cs");
                var ifilePath = Path.Combine(itmpPathOutput, $"I{name}{tail}.cs");

                var create = true;
                if (File.Exists(filePath) && File.Exists(ifilePath))
                    create = this.Ask(name, tail);

                if (create)
                {
                    var key = "@-Model-@";
                    var _tmp_ = tmp.Replace(key, name);
                    var _itmp_ = itmp.Replace(key, name);

                    File.WriteAllText(filePath, _tmp_);
                    File.WriteAllText(ifilePath, _itmp_);

                    Logger.Done($"files I{name}{tail}.cs and {name}{tail}.cs created.");
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
            }
        }

        public ServiceScaffold()
        {
            Console.Clear();
            Logger.Log("Loading the models...");

            SharedMethods.LoadModels();

            Console.Clear();
            Logger.Log(tail);
            Logger.Log("-> 1 Generate One By One");
            Logger.Log("-> 2 Generate All");
            Logger.Log("Choose an option above: ");

            var option = SharedMethods.KeyConverter<GenerationOptions>();

            switch (option)
            {
                case GenerationOptions.One:
                    Logger.Log("\nType the name of the Class: ");
                    var name = Console.ReadLine();

                    void exec(string m)
                    {
                        if (!SharedMethods.ModelExists(m)) return;
                        this.Generate(m);
                    }

                    if (!name.Contains(","))
                        exec(name);
                    else
                        name.Split(",").Select(s => s.Trim()).ToList().ForEach(m => this.Generate(m));

                    break;

                case GenerationOptions.All:
                    SharedMethods.Models.ForEach(model => this.Generate(model.Item1));
                    break;

                case GenerationOptions.Set:
                    Logger.Warn("Option unavailable!");
                    break;
            }

        }

    }
}
