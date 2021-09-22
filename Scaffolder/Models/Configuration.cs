using System.IO;

namespace Scaffolder.Models
{
    public class Configuration
    {
        // Properties
        public string Header { get; set; }
        public string Trailer { get; set; }
        public string Namespace { get; set; }

        private string mOutput;
        public string Output
        {
            get => mOutput;
            set => mOutput = this.PathNormalizer(value);
        }

        private string mTemplate;
        public string Template
        {
            get => mTemplate;
            set => mTemplate = this.PathNormalizer(value);
        }

        // Methods
        private string PathNormalizer(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            // Adding the root path to the collection
            var path = new System.Collections.Generic.List<string>
            {
                Shared.GlobalRootPath
            };

            // Adding the remain path to the list
            path.AddRange(value.Split("/"));

            // Building the full path
            return Path.Combine(path.ToArray());    
        }
    }
}