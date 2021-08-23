using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Billing.App.Handlers
{
    public class FileHandler
    {
        public string folderPath;
        public IWebHostEnvironment env;

        public string[] filters = new[] { "png", "jpg", "jpeg" };

        public FileHandler(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public FileHandler Folder(string folder)
        {
            if (string.IsNullOrEmpty(folder))
                return this;

            this.folderPath = $"{env.ContentRootPath}/Attachments/{folder}/".Replace("//", "/");

            return this;
        }

        public async Task<string> SaveAsync(IFormFile file, string fileName = null)
        {
            // Checking if is valid
            if (file == null || (file != null && file.Length == 0))
                throw new AppException("Ficheiro Inválido.", true);

            var ext = file.ToExtension();

            if (!filters.Any(x => x == ext.ToLower()))
                throw new AppException($"Formato inválido! Formatos validos: {string.Concat(filters, ',')}.", true);

            if (!Directory.Exists(this.folderPath)) Directory.CreateDirectory(this.folderPath);

            fileName = fileName ?? $"{ Guid.NewGuid().ToString("N") }.{ ext }";

            // Generating the file apth
            var fullfilePath = $"{ this.folderPath }{ fileName }";

            using (var stream = new FileStream(fullfilePath, FileMode.Create, FileAccess.Write))
                // Copying to the server
                await file.CopyToAsync(stream);

            return fullfilePath;
        }

        public async Task<string> SaveAsync(byte[] file, string fileName, string extention)
        {
            // Checking if is valid
            if (file == null || (file != null && file.Length == 0))
                throw new AppException("Ficheiro Inválido.", true);

            var ext = extention.ToLower();

            if (!filters.Any(x => x == ext.ToLower()))
                throw new AppException($"Formato inválido! Formatos validos: {string.Concat(filters, ',')}.", true);

            if (!Directory.Exists(this.folderPath)) Directory.CreateDirectory(this.folderPath);

            fileName = fileName ?? $"{ Guid.NewGuid().ToString("N") }.{ ext }";

            // Generating the file apth
            var fullfilePath = $"{ this.folderPath }{ fileName }";

            await File.WriteAllBytesAsync(fullfilePath, file);

            return fullfilePath;
        }

        // Update the file
        public async Task UpdateAsync(string filePath, IFormFile file)
        {
            // Checking if is valid
            if (file != null && file.Length == 0)
                throw new AppException("Ficheiro Inválido.", true);

            var ext = file.ToExtension();

            if (!filters.Any(x => x == ext.ToLower()))
                throw new AppException($"Formato inválido! Formatos validos: {string.Concat(filters, ',')}.", true);

            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                // Copying to the server
                await file.CopyToAsync(stream);
        }

        public async Task DeleteAsync(string filePath)
        {
            if (!File.Exists(filePath))
                throw new AppException("Ficheiro não encontrado.", true);

            // Deleting the actual file
            File.Delete(filePath);

            await Task.Delay(0);
        }
    }

    // Extentions
    public static class FileExtensions
    {
        public static string ToExtension(this IFormFile file) => file.FileName.Split(".").LastOrDefault();
        public static string ToExtension(this string path) => path.Split(".").LastOrDefault();
    }
}