using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;
using Scaffolder.Models;

namespace Scaffolder
{
    public class ConfigProvider
    {
        public List<DbModels> Models { get; set; }

        private dynamic configurations = new object();

        public ConfigProvider()
        {
            Logger.Log("Loading the configurations...");
            try
            {
                var configFilePath = "configuration.json";

                if (!File.Exists(configFilePath))
                {
                    var content = JsonConvert.SerializeObject(new
                    {
                        Models = new[]{
                            new {
                                Template = "ProjectName/Models"
                            }
                        },

                        Controller = new[]{
                            new {
                                Tail = "Controller",
                                Output = "ProjectName/Controllers/Api",
                                Template = "Scaffolder/tmp/controller.txt"
                            }
                        },

                        Service = new[]{
                            new {
                                Tail = "Service",
                                Output = "ProjectName/Services",
                                Template = "Scaffolder/tmp/service.txt"
                            }
                        },

                        ViewModel = new[]{
                            new {
                                Tail = "Dto",
                                Output = "ProjectName/Dto",
                                Template = "Scaffolder/tmp/viewmodel.txt",
                                Namespace = "ProjectNamespace",
                            }
                        },

                        EFCore = new[] {
                            new {
                                Tail = "Config",
                                Output = "ProjectName/Data",
                                Template = "Scaffolder/tmp/efconfig.txt"
                            }
                        }
                    },
                    Formatting.Indented);

                    File.WriteAllText(configFilePath, content);
                }

                this.configurations = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(configFilePath));

                // Loading the models
                this.Models = Directory.GetFiles(this.Get("Models").FirstOrDefault().Template).Select(s =>
                {
                    var fileInfo = new FileInfo(s);
                    return new DbModels
                    {
                        Name = fileInfo.Name.Replace(".cs", ""),
                        Path = fileInfo.FullName
                    };
                }).ToList();

                Logger.Done("Configurations successfuly loaded.");
                Thread.Sleep(500);
                System.Console.Clear();
            }
            catch (System.Exception ex)
            {
                Logger.Error("Error while Loading the configurations.");
                Logger.Error($"Error Description: { ex.InnerException?.Message ?? ex.Message }");

                throw;
            }
        }

        public List<Configuration> Get(string key)
        {
            try
            {
                // Creating the object
                return JsonConvert.DeserializeObject<List<Configuration>>(
                    // Accessing the data
                    this.configurations[key].ToString()
                );
            }
            catch (System.Exception ex)
            {
                Logger.Error("Error: Possivelmente a configuração desejada não existe.");
                Logger.Error($"Error Description: { ex.InnerException?.Message ?? ex.Message }");

                return null;
            }
        }
    }
}