using System;
using System.IO;
using System.Linq;

namespace Scaffolder.Scaffold
{
    public class ControllerScaffold : GenerationConditions
    {
        static string tail = "Controller";
        static string folderPath = Path.Combine("Billing.App", "Controllers", "Api");
        static string tmpPathInput = Path.Combine(SharedMethods.GlobalRootPath, "Scaffolder", "tmp", "controller.txt");
        static string tmpPathOutput = Path.Combine(SharedMethods.GlobalRootPath, folderPath);
        string tmp = File.Exists(tmpPathInput) ? File.ReadAllText(tmpPathInput) : null;

        public void Generate(string name)
        {
            try
            {
                var filePath = Path.Combine(tmpPathOutput, $"{name}{tail}.cs");
                var create = true;
                if (File.Exists(filePath))
                    create = this.Ask(name, tail);

                if (create)
                {
                    var key = "@-Model-@";
                    var _tmp_ = tmp.Replace(key, name);
                    File.WriteAllText(filePath, _tmp_);

                    Logger.Done($"file {name}{tail}.cs created.");
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
            }
        }

        public ControllerScaffold()
        {
        Begin:

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
                    goto Begin;
            }
        }
    }
}
