using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scaffolder.Models;

namespace Scaffolder.Scaffold
{
    public class ServiceScaffold : GenerationConditions
    {
        public List<Configuration> configs { get; set; }
        private string template = null;
        private string name;

        public void Generate(string name, Configuration config)
        {
            this.template = Shared.LoadTemplate(this.template, config, this.configs.Count);

            try
            {
                var filePath = Path.Combine(config.Output, $"{config.Header}{name}{config.Trailer}.cs");

                if (!this.FileExistenceHandler(filePath, name, config.Trailer))
                    return;

                File.WriteAllText(filePath, template.Replace("@-Model-@", name));
                Logger.Done($"file {config.Header}{name}{config.Trailer}.cs created.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
            }
        }

        public ServiceScaffold()
        {
        Begin:

            this.name = this.GetType().Name.Replace("Scaffold", "");

            Console.Clear();
            this.configs = Program.Config.Get(this.name);

            Logger.Log(this.name);
            Logger.Log("-> 1 Generate One By One");
            Logger.Log("-> 2 Generate All");
            Logger.Log("Choose an option above: ");

            var option = Shared.KeyConverter<GenerationOptions>();

            switch (option)
            {
                case GenerationOptions.One:
                    Logger.Log("\nType the name of the Class: ");
                    var name = Console.ReadLine();

                    void exec(string m)
                    {
                        if (!Shared.ModelExists(m)) return;
                        configs.ForEach(cf => this.Generate(m, cf));
                    }

                    if (!name.Contains(","))
                        exec(name);
                    else
                        name.Split(",").Select(s => s.Trim()).ToList().ForEach(m =>
                        {
                            configs.ForEach(cf =>
                            {
                                this.Generate(m, cf);
                            });
                        });

                    break;

                case GenerationOptions.All:
                    Program.Config.Models.ForEach(model => configs.ForEach(cf => this.Generate(model.Name, cf)));
                    break;

                default:
                case GenerationOptions.Set:
                    Logger.Warn("Option unavailable!");
                    goto Begin;
            }
        }
    }
}