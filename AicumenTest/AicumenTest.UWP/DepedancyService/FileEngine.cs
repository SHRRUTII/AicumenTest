using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Windows.Storage;
using System.Linq;
using AicumenTest.UWP.DepedancyService;
using AicumenTest.Interface;

[assembly: Dependency(typeof(FileEngine))]
namespace AicumenTest.UWP.DepedancyService
{
    class FileEngine : IFileEngine
    {

        public async Task WriteTextAsync(string storedText, string text)
        {
            StorageFolder userLocalFolder = ApplicationData.Current.LocalFolder;
            IStorageFile userStorageFile = await userLocalFolder.CreateFileAsync(storedText, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(userStorageFile, text);
        }

        public async Task<string> ReadTextAsync(string storedText)
        {
            StorageFolder userLocalFolder = ApplicationData.Current.LocalFolder;
            IStorageFile userStorageFile = await userLocalFolder.GetFileAsync(storedText);
            return await FileIO.ReadTextAsync(userStorageFile);
        }

        public async Task<IEnumerable<string>> GetFilesAsync()
        {
            StorageFolder userLocalFolder = ApplicationData.Current.LocalFolder;
            IEnumerable<string> storedTexts =
                from userStorageFile in await userLocalFolder.GetFilesAsync()
                select userStorageFile.Name;
            return storedTexts;
        }
    }
}
