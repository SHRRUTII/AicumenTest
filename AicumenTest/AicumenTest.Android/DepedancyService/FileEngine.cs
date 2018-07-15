using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AicumenTest.Droid.DepedancyService;
using AicumenTest.Interface;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(FileEngine))]
namespace AicumenTest.Droid.DepedancyService
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