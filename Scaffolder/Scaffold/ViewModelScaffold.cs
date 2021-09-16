using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Scaffolder.Scaffold
{
    public class ViewModelScaffold : GenerationConditions
    {
        static string tail = "Dto";
        static string tmpPathInput = Path.Combine(SharedMethods.GlobalRootPath, "Scaffolder", "tmp", "viewmodel.txt");
        static string tmpPathOutput = Path.Combine(SharedMethods.GlobalRootPath, "Billing.Service", "Dto");

        // Lines to be ignored
        List<(
            // ClassName
            string,
            // List of lines
            string[])>
            ignores = new List<(string, string[])>
            {
                ("*", new string[]{ "Visibility" }),
            };

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
                    // Getting the model name and path
                    var model = SharedMethods.Models.FirstOrDefault(x => x.Item1 == name);
                    // Reading the file by lines
                    var modelContent = File.ReadAllLines(model.Item2);
                    // Defining how the namespace needs to look like
                    var nameSpace = "namespace Billing.Service.Models";
                    // The out variable
                    var @out = "";

                    var ignore = ignores.FirstOrDefault(x => x.Item1 == name);

                    var isBasePropAdded = false;

                    // Looping all the lines
                    foreach (var line in modelContent)
                    {
                        string editableLine = line;

                        if (ignore.Item2 != null && ignore.Item2.Any(x => line.Contains(x))) continue;

                        // Changing the name space
                        if (editableLine.Contains(nameSpace))
                            editableLine = "namespace Billing.Service.Dto";

                        // Changing the class name
                        if (editableLine.Contains("class"))
                        {
                            if (name != "Usuario")
                                editableLine = editableLine.Replace($" class {name}", $" class {name}Dto");
                            else
                                editableLine = $"    public class {name}Dto";
                        }

                        // Changing the constructor
                        if (editableLine.Contains($"public {name}()"))
                            continue;

                        if (!isBasePropAdded && editableLine.Contains("get;") && name != "License")
                        {
                            @out += "        public string uid { get; set; }\n";
                            isBasePropAdded = true;
                        }

                        // Changing the model property type
                        if (editableLine.Contains("public virtual"))
                        {
                            var _line = editableLine.Trim();
                            var lineSplited = _line.Split(" ");
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

                            editableLine = "        " + string.Join(" ", lineSplited);
                        }

                        @out += editableLine + "\n";
                    }

                    File.WriteAllText(filePath, @out);
                    Logger.Done($"file {name}{tail}.cs created.");
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}");
            }
        }

        public ViewModelScaffold()
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
