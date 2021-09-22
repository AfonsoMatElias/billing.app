using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scaffolder.Models;

namespace Scaffolder.Scaffold
{
    public class ViewModelScaffold : GenerationConditions
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

                // Getting the model name and path
                var model = Program.Config.Models.FirstOrDefault(x => x.Name == name);
                // Reading the file by lines
                var mTemplate = this.template.Replace("@-Namespace-@", config.Namespace)
                                             .Replace("@-Model-@", model.Name);

                var properties = Shared.GetModelProperties(model.Path);

                var identation = "\n        ";
                var baseProperty = "public string uid { get; set; }";
                var propIndetifier = "@-Prop-@";

                void setter(string value)
                    => mTemplate = mTemplate.Replace(propIndetifier, $"{identation}{value}{propIndetifier}");

                setter(baseProperty);

                var count = properties.Count();
                for (int i = 1; i <= count; i++)
                {
                    // Getting the line
                    var line = properties.ElementAt(i - 1).Trim();

                    // Changing the model property type
                    if (line.Contains(" virtual "))
                    {
                        var mLine = line.Trim();
                        var lineSplited = mLine.Split(" ");
                        var type = lineSplited[2];

                        if (type.StartsWith(nameof(ICollection)))
                        {
                            type = type.Replace(nameof(ICollection) + "<", "").Replace(">", "");
                            lineSplited[2] = $"{nameof(IEnumerable)}<{type}Dto>";
                        }
                        else
                        {
                            lineSplited[2] = $"{type}Dto";
                        }

                        line = string.Join(" ", lineSplited);
                    }

                    setter(line);
                }

                File.WriteAllText(filePath, mTemplate.Replace(propIndetifier, ""));
                Logger.Done($"file {config.Header}{name}{config.Trailer}.cs created.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
            }
        }

        public ViewModelScaffold()
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
