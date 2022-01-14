using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Billing.App.Models
{
    public class AttachmentBase
    {
        [Required]
        public string Json { get; set; }

        public TModel Build<TModel>() where TModel : class
            => Newtonsoft.Json.JsonConvert.DeserializeObject<TModel>(this.Json,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
    }

    public class Attachment : AttachmentBase
    {
        public IFormFile File { get; set; }
        public bool? ToRemove { get; set; }

        public TModel Compile<TModel>(Action<TModel, byte[], IFormFile> modelResolver)
            where TModel : class
        {
            if (this.Json == null)
                return null;

            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<TModel>(this.Json,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            byte[] bytes = null;
            if (this.File == null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    this.File.CopyTo(ms);
                    bytes = ms.ToArray();
                }
            }

            if (modelResolver != null)
                modelResolver.Invoke(model, bytes, this.File);

            return model;
        }
    }

    public class Attachments : AttachmentBase
    {
        public IFormFile[] Files { get; set; } = new List<IFormFile>().ToArray();
        public bool? ToRemove { get; set; }
        
        public TModel Compile<TModel>(Action<TModel, List<byte[]>, IFormFile[]> modelResolver)
            where TModel : class
        {
            if (this.Json == null) return null;
            var model = Newtonsoft.Json.JsonConvert.DeserializeObject<TModel>(this.Json);

            List<byte[]> files = new List<byte[]>();
            if (this.Files != null)
            {
                files = this.Files.Select(file =>
                {
                    byte[] bytes = null;
                    using (var ms = new System.IO.MemoryStream())
                    {
                        file.CopyTo(ms);
                        bytes = ms.ToArray();
                    }

                    return bytes;
                }).ToList();
            }

            if (modelResolver != null)
                modelResolver.Invoke(model, files, this.Files);

            return model;
        }
    }
}