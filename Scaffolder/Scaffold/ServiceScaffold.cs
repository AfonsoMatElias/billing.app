﻿using System;
using System.IO;
using System.Linq;

namespace Scaffolder.Scaffold
{
    public class ServiceScaffold : GenerationConditions
    {
        static string tail = "Service";

        static string tmpPathInput = SharedMethods.GlobalRootPath + @"Scaffolder/tmp/service.txt";
        static string itmpPathInput = SharedMethods.GlobalRootPath + @"Scaffolder/tmp/iservice.txt";

        static string tmpPathOutput = SharedMethods.GlobalRootPath + @"Billing.Service/Services/Implementations/";
        static string itmpPathOutput = SharedMethods.GlobalRootPath + @"Billing.Service/Services/Interfaces/";

        string tmp = File.Exists(tmpPathInput) ? File.ReadAllText(tmpPathInput) : null;
        string itmp = File.Exists(itmpPathInput) ? File.ReadAllText(itmpPathInput) : null;

        public void Generate(string name)
        {
            try
            {
                var filePath = tmpPathOutput + $"{name}{tail}.cs";
                var ifilePath = itmpPathOutput + $"I{name}{tail}.cs";

                var create = true;
                if (File.Exists(filePath) && File.Exists(ifilePath))
                    create = this.Ask(name, tail);
                
                if(create)
                {
                    var key = "@-Model-@";
                    var _tmp_ = tmp.Replace(key, name);
                    var _itmp_ = itmp.Replace(key, name);

                    File.WriteAllText(filePath, _tmp_);
                    File.WriteAllText(ifilePath, _itmp_);

                    SharedMethods.ChangeColor(ConsoleColor.Green, () => Console.WriteLine($"files I{name}{tail}.cs and {name}{tail}.cs created."));
                }
            }
            catch (Exception ex)
            {
                SharedMethods.ChangeColor(ConsoleColor.Red, () => Console.WriteLine($"Error: {ex.Message} ; {ex.InnerException?.Message ?? ""}"));
            }
        }

        public ServiceScaffold()
        {
            Console.Clear();
            Console.WriteLine(@"Loading the models...");

            SharedMethods.LoadModels();

            Console.Clear();
            Console.WriteLine(tail);
            Console.WriteLine(@"-> 1 Generate One By One");
            Console.WriteLine(@"-> 2 Generate All");
            Console.WriteLine(@"Choose an option above: ");

            var option = SharedMethods.KeyConverter<GenerationOptions>();

            switch (option)
            {
                case GenerationOptions.One:
                    Console.WriteLine("\nType the name of the Class: ");
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
                    SharedMethods.ChangeColor(ConsoleColor.Yellow, () => {
                        Console.WriteLine("Option unavailable!");
                    });
                    break;
            }

        }
        
    }
}
