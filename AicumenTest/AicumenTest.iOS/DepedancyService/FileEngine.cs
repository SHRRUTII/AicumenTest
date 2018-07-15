using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using AicumenTest;
using System.Threading.Tasks;
using AicumenTest.iOS.DepedancyService;
using AicumenTest.Interface;

[assembly: Dependency(typeof(FileEngine))]
namespace AicumenTest.iOS.DepedancyService
{
    class FileEngine : IFileEngine
    {
        public Task<IEnumerable<string>> GetFilesAsync()
        {
            IEnumerable<string> storedTexts =
                from filePath in Directory.EnumerateFiles(DocsPath())
                select Path.GetFileName(filePath);
            return Task<IEnumerable<string>>.FromResult(storedTexts);
        }

        public async Task<string> ReadTextAsync(string storedText)
        {
            string filePath = FilePath(storedText);
            using (StreamReader reader = File.OpenText(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public async Task WriteTextAsync(string storedText, string text)
        {
            string filePath = FilePath(storedText);
            using (StreamWriter writer = File.CreateText(filePath))
            {
                await writer.WriteAsync(text);
            }
        }

        private string FilePath(string storedText)
        {
            return Path.Combine(DocsPath(), storedText);
        }

        private string DocsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}