using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scaffolder.Models;

namespace Scaffolder.Scaffold
{
    public class EFCoreScaffold : GenerationConditions
    {
        public List<Configuration> configs { get; set; }
        private string template = null;
        private string name;

        // Aditionals configuration according to the the type of property
        private Dictionary<string, string[]> typeAditionals = new Dictionary<string, string[]>
        {
            {
                "string", new[] { ".HasMaxLength(200)", }
            },
            {
                "decimal", new[] { ".HasPrecision(18, 2)", }
            }
        };


        public void Generate(string name, Configuration config)
        {
            this.template = Shared.LoadTemplate(this.template, config, this.configs.Count);

            try
            {
                var filePath = Path.Combine(config.Output, "Configurations", $"{config.Header}{name}{config.Trailer}.cs");

                if (!this.FileExistenceHandler(filePath, name, config.Trailer))
                    return;

                // Getting the model name and path
                var model = Program.Config.Models.FirstOrDefault(x => x.Name == name);
                // Reading the file by lines
                var mTemplate = this.template.Replace("@-Model-@", model.Name);

                var properties = Shared.GetModelProperties(model.Path);

                var identation = "\n            ";
                var propIndetifier = "@-Prop-@";

                void setter(string value)
                    => mTemplate = mTemplate.Replace(propIndetifier, $"{identation}{value}{propIndetifier}");

                string propertyBuilder(string propType, string propName)
                {
                    var ads = new List<string>() { "" };
                    if (typeAditionals.ContainsKey(propType))
                        ads.AddRange(typeAditionals[propType]);

                    return $"builder.Property(e => e.@-Name-@)@-Aditional-@{ identation + "       " }.IsRequired(false);\n"
                        .Replace("@-Name-@", propName)
                        .Replace("@-Aditional-@", string.Join(identation + "       ", ads));
                }

                string virtualPropertyBuilder(string propType, string propName)
                {
                    var ads = new List<string>() { "" };
                    if (typeAditionals.ContainsKey(propType))
                        ads.AddRange(typeAditionals[propType]);

                    return $"builder.HasOne(e => e.{ propName })" +
                         string.Join(identation + "       ", new string[] {
                             $".WithMany(e => e.{ name }s)",
                             $".HasForeignKey(e => e.{ propName }Id)",
                             ".OnDelete(DeleteBehavior.NoAction);"
                         });

                    return $"builder.Property(e => e.@-Name-@)@-Aditional-@{ identation + "       " }.IsRequired(false);\n"
                        .Replace("@-Name-@", propName)
                        .Replace("@-Aditional-@", string.Join(identation + "       ", ads));
                }

                var count = properties.Count();
                for (int i = 1; i <= count; i++)
                {
                    // Getting the line
                    var line = properties.ElementAt(i - 1).Trim();
                    var lineSplited = line.Split(" ");

                    var propName = lineSplited[2];
                    var propType = lineSplited[1];

                    // Skiping the virtual properties
                    if (line.Contains(" virtual "))
                    {
                        setter(propertyBuilder(propType, propName)); continue;
                    }

                    setter(propertyBuilder(propType, propName));
                }

                File.WriteAllText(filePath, mTemplate.Replace(propIndetifier, ""));
                Logger.Done($"file {config.Header}{name}{config.Trailer}.cs created.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
            }
        }

        public EFCoreScaffold()
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
